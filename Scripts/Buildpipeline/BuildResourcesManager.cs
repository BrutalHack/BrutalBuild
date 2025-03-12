using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.Enums;
using BrutalHack.Submodules.BrutalBuild.Scripts.Config;
using BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build;
using UnityEditor;
using UnityEngine;
using AppContext = BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.Enums.AppContext;
using Environment = BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.Enums.Environment;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline
{
	public class BuildResourcesManager
	{
		private const string BuildResourcesPath = "Assets/BuildResources/";
		private const string ResourcesPath = "/Assets/Resources/";
		private const string AndroidPluginsPath = "/Assets/Plugins/Android/";
		private readonly AppContext _appContext;
		private readonly Environment _environment;
		private readonly BuildType _buildType;
		private readonly string _generalContext = "General";

		private static string _runTimeResourcesDirName = "_Runtime";

		/// <summary>
		/// Initializes the BuildManager with the given Context
		/// </summary>
		/// <param name="appContext"></param>
		/// <param name="environment"></param>
		/// <param name="buildType"></param>
		public BuildResourcesManager(AppContext appContext, Environment environment, BuildType buildType)
		{
			_appContext = appContext;
			_environment = environment;
			_buildType = buildType;
		}

		/// <summary>
		/// Imports the Build Config for the current context.
		/// Includes CloudConfig. Intended to be used to change app context within the editor. 
		/// </summary>
		/// <param name="appContext"></param>
		/// <param name="environment"></param>
		/// <param name="buildType"></param>
		public void ImportBuildConfig()
		{

			var buildConfig = GetBuildConfig();
			UnityConnectUtils.SetCloudProjectId(buildConfig.UnityCloudSettings);
			PlayerSettingsAdapter.Import(buildConfig.PlayerSettings);
			AddAppContextToDefineSymbols();
		}

		/// <summary>
		/// Copies the runtime xml files of a given context configuration to the Resources/ directory. 
		/// </summary>
		/// <param name="appContext"></param>
		/// <param name="environment"></param>
		/// <param name="buildType"></param>
		private void CopyRuntimeFilesToResources()
		{
			DeleteDirectoryContents(ResourcesPath);
			ImportRuntimeResources();
			Debug.Log("Copied runtime files.");
		}

		public void SetContext()
		{
			CopyAndroidManifest();
			CopyGoogleServicesPlist();
			CopyRuntimeFilesToResources();
			ImportBuildConfig();
		}

		/// <summary>
		/// Deletes the Resources directory. Intended to be called before importing files of a different context
		/// </summary>
		private static void DeleteDirectoryContents(string resourcesPath)
		{
			foreach (var subDirPath in Directory.GetDirectories(Directory.GetCurrentDirectory() + resourcesPath))
			{
				Directory.Delete(subDirPath, true);
			}

			foreach (var filePath in Directory.GetFiles(Directory.GetCurrentDirectory() + resourcesPath))
			{
				File.Delete(filePath);
			}
		}

		private void ImportRuntimeResources()
		{
			var targetDirPath = Directory.GetCurrentDirectory() + ResourcesPath;

			var buildResourcesAbsolutePath = Directory.GetCurrentDirectory() + "/" + BuildResourcesPath;

			var runtimeResourceContextPaths = new List<string>
			{
				_generalContext + "/" + _runTimeResourcesDirName,
				_generalContext + "/" + _environment + "/" + _runTimeResourcesDirName,
				_generalContext + "/" + _environment + "/" + _buildType + "/" + _runTimeResourcesDirName,
				_appContext + "/" + _runTimeResourcesDirName,
				_appContext + "/" + _environment + "/" + _runTimeResourcesDirName,
				_appContext + "/" + _environment + "/" + _buildType + "/" + _runTimeResourcesDirName
			};
			foreach (var contextPath in runtimeResourceContextPaths)
			{
				var sourceDirPath = buildResourcesAbsolutePath + contextPath;
				if (Directory.Exists(sourceDirPath))
				{
					CopyDirectory(sourceDirPath, targetDirPath, true);
				}
			}

			ReimportDirectory(targetDirPath);
		}

		private static void ReimportDirectory(string targetDirPath)
		{
			// skip .meta files and other irrelevant files
			var assetFiles = Directory.GetFiles(targetDirPath, "*", SearchOption.AllDirectories)
				.Where(path => !path.EndsWith(".meta") && !Path.GetFileName(path).Equals(".DS_Store"))
				.ToArray();
			for (var index = 0; index < assetFiles.Length; index++)
			{
				string assetFilePath = assetFiles[index];
				string assetDatabasePath = assetFilePath.Substring((Directory.GetCurrentDirectory() + "/").Length);
				AssetDatabase.ImportAsset(assetDatabasePath);
//                Logger.Log("Asset " + (index + 1) + " of " + assetFiles.Length + " imported: " + assetDatabasePath);
			}
		}

		private void AddAppContextToDefineSymbols()
		{
			var buildTargetGroups = new List<BuildTargetGroup> {BuildTargetGroup.iOS, BuildTargetGroup.Android};
			foreach (var buildTargetGroup in buildTargetGroups)
			{
				var currentDefineSymbols = PlayerSettings.GetScriptingDefineSymbolsForGroup(buildTargetGroup);
				PlayerSettings.SetScriptingDefineSymbolsForGroup(buildTargetGroup,
					currentDefineSymbols + ";" + _appContext.ToString().ToUpperInvariant());
			}

			Debug.Log(@"Added """ + _appContext.ToString().ToUpperInvariant() + @""" to Define Symbols");
		}

		/// <summary>
		/// Gets a file from the given directory. If it is not found, the search recursively traverses the parent directories.
		/// </summary>
		/// <param name="directory"></param>
		/// <param name="filename"></param>
		/// <param name="directoryNameToAbortOn"></param>
		/// <returns></returns>
		/// <exception cref="System.InvalidOperationException"> When the file was not found.</exception>
		private static FileInfo GetFileBeneathBuildResourcesRecursive(DirectoryInfo directory, string filename,
			string directoryNameToAbortOn = "BuildResources")
		{
			if (directory.Name.Equals(directoryNameToAbortOn) ||
			    directory.FullName.Equals(Path.GetPathRoot(directory.FullName)))
			{
				return null;
			}

			var filePath = directory.FullName + "/" + filename;
			return File.Exists(filePath)
				? new FileInfo(filePath)
				: GetFileBeneathBuildResourcesRecursive(directory.Parent, filename);
		}

		private static void CopyDirectory(string sourceDirName, string destDirName, bool copySubDirs)
		{
			// Get the subdirectories for the specified directory.
			DirectoryInfo dir = new DirectoryInfo(sourceDirName);

			if (!dir.Exists)
			{
				throw new DirectoryNotFoundException(
					"Source directory does not exist or could not be found: "
					+ sourceDirName);
			}

			DirectoryInfo[] dirs = dir.GetDirectories();
			// If the destination directory doesn't exist, create it.
			if (!Directory.Exists(destDirName))
			{
				Directory.CreateDirectory(destDirName);
			}

			// Get the files in the directory and copy them to the new location.
			FileInfo[] files = dir.GetFiles();
			foreach (FileInfo file in files)
			{
				string tempPath = Path.Combine(destDirName, file.Name);
				file.CopyTo(tempPath, true);
			}

			// If copying subdirectories, copy them and their contents to new location.
			if (copySubDirs)
			{
				foreach (DirectoryInfo subdir in dirs)
				{
					string temppath = Path.Combine(destDirName, subdir.Name);
					CopyDirectory(subdir.FullName, temppath, copySubDirs);
				}
			}
		}

		[Obsolete("For testing and internal use only.")]
		public BuildConfig GetBuildConfig()
		{
			var xmlFileLocation = GetFile("BuildConfig.xml").FullName;

			var buildConfigSerializer = new XmlSerializer(typeof(BuildConfig));
			var reader = new StreamReader(xmlFileLocation);

			var buildConfig = (BuildConfig) buildConfigSerializer.Deserialize(reader);
			return buildConfig;
		}
		
		private void CopyGoogleServicesPlist()
		{
			var filename = "GoogleService-Info.plist";
			FileInfo file = GetFile(filename);
			file.CopyTo(Directory.GetCurrentDirectory() + "/Assets/" + filename, true);
		}

		private void CopyAndroidManifest()
		{
			var filename = "AndroidManifest.xml";
			FileInfo file = GetFile(filename);
			file.CopyTo(Directory.GetCurrentDirectory() + "/Assets/Plugins/Android/" + filename, true);
		}

		[Obsolete("For testing and internal use only.")]
		public FileInfo GetFile(string filename)
		{
			var contextPath = BuildResourcesPath + _appContext + "/" + _environment + "/" + _buildType;
			var contextDirectory = new DirectoryInfo(Directory.GetCurrentDirectory() + "/" + contextPath);
			var file = GetFileBeneathBuildResourcesRecursive(contextDirectory, filename);

			if (file == null)
			{
				var generalPath = BuildResourcesPath + _generalContext + "/" + _environment + "/" + _buildType;
				var generalDirectory = new DirectoryInfo(Directory.GetCurrentDirectory() + "/" + generalPath);
				file = GetFileBeneathBuildResourcesRecursive(generalDirectory, filename);
			}

			if (file != null)
			{
				return file;
			}

			throw new InvalidOperationException("Could not find file " + filename + " in BuildResources.\n" +
			                                    "Context: " + _appContext +
			                                    ", Environment: " + _environment +
			                                    ", BuildType: " + _buildType);
		}
	}
}