using System;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;
using BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.Enums;
using UnityEditor;
using UnityEngine;
using AppContext = BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.Enums.AppContext;
using Debug = UnityEngine.Debug;
using Environment = BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.Enums.Environment;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline
{
    public class BuildController
    {
        private static string _androidBuildPath = "Build/Android";
        private static string _iOSBuildPath = "Build/iOS";

        /// <summary>
        /// Sets the Editors Context to the given app and configuration (Backend Environment, Debug or Release Mode)
        /// </summary>
        /// <param name="appContext"></param>
        /// <param name="environment"></param>
        /// <param name="buildType"></param>
        public static void SetContext(AppContext appContext, Environment environment)
        {
            Debug.Log("Starting Context Switch.\n" +
                      "App: " + appContext + ", environment: " + environment);

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var buildResourcesManager = new BuildResourcesManager(appContext, environment);
            buildResourcesManager.SetContext();
            stopwatch.Stop();
            var buildDuration = stopwatch.Elapsed;

            Debug.Log(
                $"Finished Import in {buildDuration.TotalSeconds} seconds.\n" +
                $"App: {appContext}, environment: {environment}");
        }


        /// <summary>
        /// Switches context and builds a player with the given configuration.
        /// </summary>
        /// <param name="appContext">The App to build the Player for</param>
        /// <param name="environment">Which Server to target</param>
        /// <param name="buildType">Development (with Debug Modes) or release build</param>
        /// <param name="targetPlatform">Android or iOS</param>
        /// <param name="scenePaths"></param>
        /// <param name="iosTargetSdk">If iOS, define Device or Simulator SDK</param>
        /// <param name="isReleaseBuild"></param>
        /// <exception cref="System.InvalidOperationException"></exception>
        public static void BuildApplication(AppContext appContext, Environment environment,
            BuildTarget targetPlatform, iOSSdkVersion iosTargetSdk = iOSSdkVersion.DeviceSDK,
            bool isReleaseBuild = false, string[] scenePaths = null)
        {
            BuildController.SetContext(AppContext.Release, Environment.Dev);

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Debug.Log("Starting Build.\n" +
                      "App: " + appContext + ", environment: " + environment + "\n" +
                      "iOS Target (if iOS Build): " + iosTargetSdk);

            if (targetPlatform == BuildTarget.Android)
            {
                EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
            }
            else if (targetPlatform == BuildTarget.iOS)
            {
                EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.iOS, BuildTarget.iOS);
            }

            SetContext(appContext, environment);

            var buildPlayerOptions = new BuildPlayerOptions();
            switch (targetPlatform)
            {
                case BuildTarget.iOS:
                    buildPlayerOptions.locationPathName =
                        $"{_iOSBuildPath}/{appContext}-{environment}-{iosTargetSdk}";
                    buildPlayerOptions.target = BuildTarget.iOS;
                    PlayerSettings.iOS.sdkVersion = iosTargetSdk;
                    break;
                case BuildTarget.Android:
                    buildPlayerOptions.locationPathName =
                        $"{_androidBuildPath}/{appContext}-{environment}.apk";
                    buildPlayerOptions.target = BuildTarget.Android;
                    buildPlayerOptions.options |= BuildOptions.AutoRunPlayer;
                    break;
                default:
                    throw new InvalidOperationException("Invalid Build target : " + targetPlatform);
            }

            if (scenePaths != null)
            {
                buildPlayerOptions.scenes = scenePaths;
            }

            if (environment == Environment.Dev)
            {
                buildPlayerOptions.options |= BuildOptions.Development;
                buildPlayerOptions.options |= BuildOptions.AllowDebugging;
                buildPlayerOptions.options |= BuildOptions.WaitForPlayerConnection;
            }

            if (isReleaseBuild)
            {
                PlayerSettings.bundleVersion = GitUtilities.GetReleaseVersionIfOnGitBranch();
            }
            else
            {
                PlayerSettings.SetIncrementalIl2CppBuild(BuildTargetGroup.iOS, true);
                buildPlayerOptions.options |= BuildOptions.AcceptExternalModificationsToPlayer;
            }

            PrintBuildSettings(buildPlayerOptions);
            BuildPipeline.BuildPlayer(buildPlayerOptions);
            //Reimport Build Settings, in case we modified something temporarily
            var buildResourcesManager = new BuildResourcesManager(appContext, environment);
            buildResourcesManager.ImportBuildConfig();
            stopwatch.Stop();
            var buildDuration = stopwatch.Elapsed.TotalSeconds;
            Debug.Log("Finished build in " + buildDuration + " seconds.\n" +
                      "App: " + appContext + ", environment: " + environment + "\n" +
                      "iOS Target (if iOS Build): " + iosTargetSdk);
        }

        private static void PrintBuildSettings(BuildPlayerOptions buildPlayerOptions)
        {
            Debug.Log("Building " + PlayerSettings.productName + " for Platform " + buildPlayerOptions.target);
        }

        public static bool CanBuildTargetToIL2CPP(BuildTarget target)
        {
            return Application.platform == GetHostPlatform(target);
        }

        static RuntimePlatform GetHostPlatform(BuildTarget target)
        {
            switch (target)
            {
                case BuildTarget.StandaloneOSX:
                    return RuntimePlatform.OSXEditor;
                case BuildTarget.StandaloneLinux64:
                    return RuntimePlatform.LinuxEditor;
                case BuildTarget.StandaloneWindows:
                case BuildTarget.StandaloneWindows64:
                    return RuntimePlatform.WindowsEditor;
                default:
                    throw new Exception(string.Format("BuildTarget.{0} is not a standalone player build target!"));
            }
        }


        /// <summary>
        /// Serializes the config of a given Type to Assets/BuildResources
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static void ExportConfig<T>() where T : new()
        {
            Directory.CreateDirectory("Assets/BuildResources/Exported");
            var xmlFileLocation =
                $"Assets/BuildResources/Exported/{typeof(T).Name}-{DateTime.Today.ToString("yyyy-mm-dd")}.xml";

            TextWriter writer = new StreamWriter(xmlFileLocation);
            var globalSettingsSerializer = new XmlSerializer(typeof(T));
            globalSettingsSerializer.Serialize(writer, new T());
            Debug.Log(typeof(T).Name + " written to " + xmlFileLocation);
        }
    }
}