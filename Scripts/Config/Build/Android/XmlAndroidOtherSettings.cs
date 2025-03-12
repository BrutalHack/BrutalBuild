using System;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build.Android
{
    [Serializable]
    public class XmlAndroidOtherSettings
    {
        // Rendering
        public string ColorSpace = PlayerSettingsAdapter.Android.ColorSpace;
        public bool AutoGraphicsApi = PlayerSettingsAdapter.Android.AutoGraphicsApi;
        public bool MultithreadedRendering = PlayerSettingsAdapter.Android.MultithreadedRendering;
        public bool GpuSkinning = PlayerSettingsAdapter.Android.GpuSkinning;
        public bool GraphicsJobs = PlayerSettingsAdapter.Android.GraphicsJobs;
        public bool ProtectGraphicsMemory = PlayerSettingsAdapter.Android.ProtectGraphicsMemory;

        // Identification
        public string BundleIdentifier = PlayerSettingsAdapter.Android.BundleIdentifier;
        public int BundleVersionCode = PlayerSettingsAdapter.Android.BundleVersionCode;
        public string MinimumApiLevel = PlayerSettingsAdapter.Android.MinimumApiLevel;
        public string TargetSdkVersion = PlayerSettingsAdapter.Android.TargetSdkVersion;

        // Configuration
        public string ScriptingRuntimeVersion = PlayerSettingsAdapter.Android.ScriptingRuntimeVersion;
        public string ScriptingBackend = PlayerSettingsAdapter.Android.ScriptingBackend;

        public string ApiCompatibilityLevel =
            PlayerSettingsAdapter.Android.ApiCompatibilityLevel;

        public string CppCompilerConfiguration =
            PlayerSettingsAdapter.Android.CppCompilerConfiguration;


        public bool MuteOtherAudioSources = PlayerSettingsAdapter.Android.MuteOtherAudioSources;
        public string Architecture = PlayerSettingsAdapter.Android.Architecture;

        public string InstallLocation = PlayerSettingsAdapter.Android.InstallLocation;
        public bool ForceInternetPermission = PlayerSettingsAdapter.Android.ForceInternetPermission;
        public bool ForceSdCardPermission = PlayerSettingsAdapter.Android.ForceSdCardPermission;

        public bool AndroidGame = PlayerSettingsAdapter.Android.AndroidGame;
        public bool AndroidTvCompatibility = PlayerSettingsAdapter.Android.AndroidTvCompatibility;
        
        public string ScriptingDefineSymbols =
            PlayerSettingsAdapter.Android.ScriptingDefineSymbols;

        public bool AllowUnsafeCode = PlayerSettingsAdapter.Android.AllowUnsafeCode;

        // Optimization
        public bool PrebakeCollisionMeshes = PlayerSettingsAdapter.Android.PrebakeCollisionMeshes;
        public string AotOptions = PlayerSettingsAdapter.Android.AotOptions;
        public bool StripEngineCode = PlayerSettingsAdapter.Android.StripEngineCode;
    }
}