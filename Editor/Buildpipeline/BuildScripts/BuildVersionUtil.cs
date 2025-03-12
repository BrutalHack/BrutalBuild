using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.Build.Reporting;
using Debug = UnityEngine.Debug;

namespace DokiDokiRagnarok.Editor.BuildScripts
{
    public static class BuildVersionUtil
    {
        public static void GenerateBuild(BuildPlayerOptions buildPlayerOptions)
        {
            var report = BuildPipeline.BuildPlayer(buildPlayerOptions);
            var summary = report.summary;

            if (summary.result == BuildResult.Succeeded)
            {
                Debug.Log("Build succeeded: " + summary.outputPath);
            }
            else
            {
                Debug.LogError($"Build {summary.result}");
                throw new InvalidOperationException("Build Aborted.");
            }
        }

        public static void SetKeystorePasswordsFromEnvironment()
        {
            var projectPath = Directory.GetCurrentDirectory();
            const string fileName = ".env";
            var filePath = $"{projectPath}/{fileName}";
            if (File.Exists(filePath))
            {
                foreach (var line in File.ReadAllLines(filePath))
                {
                    var parts = line.Split(
                        '=',
                        StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length != 2)
                        continue;

                    Environment.SetEnvironmentVariable(parts[0], parts[1]);
                }
            }

            var keystorePassword = Environment.GetEnvironmentVariable("KEYSTORE_PASSWORD");
            PlayerSettings.Android.keystorePass = keystorePassword;
            var keyPassword = Environment.GetEnvironmentVariable("KEY_PASSWORD");
            PlayerSettings.Android.keyaliasPass = keyPassword;
        }

        public static void RestoreGooglePlayGamesSettings()
        {
            var projectPath = Directory.GetCurrentDirectory();
            const string fileName = "GooglePlayGamesSettings.txt";
            var sourceFilePath = $"{projectPath}/Assets/BuildResources/{fileName}";
            var targetFilePath = $"{projectPath}/ProjectSettings/{fileName}";
            if (!File.Exists(sourceFilePath))
            {
                Debug.LogWarning("Could not find Backup for GooglePlayGamesService.txt");
                return;
            }

            File.Copy(sourceFilePath, targetFilePath, true);
            Debug.Log($"Copied {fileName} from {sourceFilePath} to {targetFilePath}");
        }

        private static double BuildWithStopWatch(Stopwatch stopwatch, Action action)
        {
            stopwatch.Restart();
            action.Invoke();
            stopwatch.Stop();
            var secondsElapsed = stopwatch.Elapsed.TotalSeconds;
            Debug.Log($"Finished Build in {secondsElapsed}s");
            stopwatch.Restart();
            return secondsElapsed;
        }
    }
}