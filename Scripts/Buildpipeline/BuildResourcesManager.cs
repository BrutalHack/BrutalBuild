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
		private readonly AppContext _appContext;
		private readonly Environment _environment;
		private readonly string _defaultContext = "Default";

		private static string _runTimeResourcesDirName = "_Runtime";

		/// <summary>
		/// Initializes the BuildManager with the given Context
		/// </summary>
		/// <param name="appContext"></param>
		/// <param name="environment"></param>
		/// <param name="buildType"></param>
		public BuildResourcesManager(AppContext appContext, Environment environment)
		{
			_appContext = appContext;
			_environment = environment;
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
        
		public void SetContext()
		{
			// CopyAndroidManifest();
			// CopyGoogleServicesPlist();
			ImportBuildConfig();
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
			var contextPath = BuildResourcesPath + _appContext + "/" + _environment;
			var contextDirectory = new DirectoryInfo(Directory.GetCurrentDirectory() + "/" + contextPath);
			var file = GetFileBeneathBuildResourcesRecursive(contextDirectory, filename);

			if (file == null)
			{
				var defaultPath = BuildResourcesPath + _defaultContext + "/" + _environment;
				var defaultDirectory = new DirectoryInfo(Directory.GetCurrentDirectory() + "/" + defaultPath);
				file = GetFileBeneathBuildResourcesRecursive(defaultDirectory, filename);
			}

			if (file != null)
			{
				return file;
			}

			throw new InvalidOperationException("Could not find file " + filename + " in BuildResources.\n" +
			                                    "Context: " + _appContext +
			                                    ", Environment: " + _environment);
		}
	}
}