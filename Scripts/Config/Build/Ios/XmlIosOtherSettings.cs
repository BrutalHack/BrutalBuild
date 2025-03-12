using System;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build.Ios
{
    [Serializable]
    public class XmlIosOtherSettings
    {
        // Rendering
        public string ColorSpace = PlayerSettingsAdapter.Ios.ColorSpace;
        public bool AutoGraphicsApi = PlayerSettingsAdapter.Ios.AutoGraphicsApi;
        public bool MetalApiValidation = PlayerSettingsAdapter.Ios.MetalApiValidation;
        public bool ForceHardShadowsOnMetal = PlayerSettingsAdapter.Ios.ForceHardShadowsOnMetal;
        public bool MultithreadedRendering = PlayerSettingsAdapter.Ios.MultithreadedRendering;
        public bool GpuSkinning = PlayerSettingsAdapter.Ios.GpuSkinning;
        public bool GraphicsJobs = PlayerSettingsAdapter.Ios.GraphicsJobs;

        // Identification
        public string BundleIdentifier = PlayerSettingsAdapter.Ios.BundleIdentifier;
        public string Build = PlayerSettingsAdapter.Ios.Build;
        public string SigningTeamId = PlayerSettingsAdapter.Ios.SigningTeamId;
        public bool AutomaticallySign = PlayerSettingsAdapter.Ios.AutomaticallySign;


        // Configuration
        public string ScriptingRuntimeVersion = PlayerSettingsAdapter.Ios.ScriptingRuntimeVersion;
        public string ScriptingBackend = PlayerSettingsAdapter.Ios.ScriptingBackend;
        public string ApiCompatibilityLevel = PlayerSettingsAdapter.Ios.ApiCompatibilityLevel;
        public bool UseOnDemandResources = PlayerSettingsAdapter.Ios.UseOnDemandResources;
        public int AccelerometerFrequency = PlayerSettingsAdapter.Ios.AccelerometerFrequency;

        public string CameraUsageDescription = PlayerSettingsAdapter.Ios.CameraUsageDescription;
        public string LocationUsageDescription = PlayerSettingsAdapter.Ios.LocationUsageDescription;
        public string MicrophoneUsageDescription = PlayerSettingsAdapter.Ios.MicrophoneUsageDescription;

        public bool MuteOtherAudioSources = PlayerSettingsAdapter.Ios.MuteOtherAudioSources;
        public bool RequiresPersistentWifi = PlayerSettingsAdapter.Ios.RequiresPersistentWifi;
        public bool AllowDownloadsOverHttp = PlayerSettingsAdapter.Ios.AllowDownloadsOverHttp;
        public string TargetDevice = PlayerSettingsAdapter.Ios.TargetDevice;
        public string TargetSdk = PlayerSettingsAdapter.Ios.TargetSdk;
        public string TargetMinimumIosSdk = PlayerSettingsAdapter.Ios.TargetMinimumIosSdk;
        public string DeferSystemGesturesMode = PlayerSettingsAdapter.Ios.DeferSystemGesturesMode;
        public bool HideHomeButtonOnIphoneX = PlayerSettingsAdapter.Ios.HideHomeButtonOnIphoneX;
        public string BehaviorInBackground = PlayerSettingsAdapter.Ios.BehaviorInBackground;
        public int Architecture = PlayerSettingsAdapter.Ios.Architecture;
        public string ScriptingDefineSymbols = PlayerSettingsAdapter.Ios.ScriptingDefineSymbols;
        public bool AllowUnsafeCode = PlayerSettingsAdapter.Ios.AllowUnsafeCode;

        // Optimization
        public bool PrebakeCollisionMeshes = PlayerSettingsAdapter.Ios.PrebakeCollisionMeshes;
        public string AotOptions = PlayerSettingsAdapter.Ios.AotOptions;
        public bool StripEngineCode = PlayerSettingsAdapter.Ios.StripEngineCode;
        public string ScriptCallOptimization = PlayerSettingsAdapter.Ios.ScriptCallOptimization;
    }
}