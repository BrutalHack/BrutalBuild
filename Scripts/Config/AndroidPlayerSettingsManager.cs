using UnityEditor;
using UnityEngine;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config
{
    public class AndroidPlayerSettingsManager
    {
        #region Android Resolution and Presentation

        public bool PreserveFramebufferAlpha
        {
            get => PlayerSettings.preserveFramebufferAlpha;
            set => PlayerSettings.preserveFramebufferAlpha = value;
        }

        public string BlitType
        {
            get => PlayerSettings.Android.blitType.ToString();
            set => PlayerSettings.Android.blitType = EnumUtils.ParseEnum<AndroidBlitType>(value);
        }

        public string DefaultOrientation
        {
            get => PlayerSettings.defaultInterfaceOrientation.ToString();
            set => PlayerSettings.defaultInterfaceOrientation = EnumUtils.ParseEnum<UIOrientation>(value);
        }

        public bool AllowedAutorotateToPortrait
        {
            get => PlayerSettings.allowedAutorotateToPortrait;
            set => PlayerSettings.allowedAutorotateToPortrait = value;
        }

        public bool AllowedAutorotateToLandscapeLeft
        {
            get => PlayerSettings.allowedAutorotateToLandscapeLeft;
            set => PlayerSettings.allowedAutorotateToLandscapeLeft = value;
        }

        public bool AllowedAutorotateToLandscapeRight
        {
            get => PlayerSettings.allowedAutorotateToLandscapeRight;
            set => PlayerSettings.allowedAutorotateToLandscapeRight = value;
        }

        public bool AllowedAutorotateToPortraitUpsideDown
        {
            get => PlayerSettings.allowedAutorotateToPortraitUpsideDown;
            set => PlayerSettings.allowedAutorotateToPortraitUpsideDown = value;
        }

        public bool Use32BitDisplayBuffer
        {
            get => PlayerSettings.use32BitDisplayBuffer;
            set => PlayerSettings.use32BitDisplayBuffer = value;
        }

        public bool DisableDepthAndStencil
        {
            get => PlayerSettings.Android.disableDepthAndStencilBuffers;
            set => PlayerSettings.Android.disableDepthAndStencilBuffers = value;
        }

        public string ShowLoadingIndicator
        {
            get => PlayerSettings.Android.showActivityIndicatorOnLoading.ToString();
            set =>
                PlayerSettings.Android.showActivityIndicatorOnLoading =
                    EnumUtils.ParseEnum<AndroidShowActivityIndicatorOnLoading>(value);
        }

        #endregion

        #region Android Other

        #region Rendering

        public string ColorSpace
        {
            get => PlayerSettings.colorSpace.ToString();
            set => PlayerSettings.colorSpace = EnumUtils.ParseEnum<ColorSpace>(value);
        }

        public bool AutoGraphicsApi
        {
            get => PlayerSettings.GetUseDefaultGraphicsAPIs(BuildTarget.Android);
            set => PlayerSettings.SetUseDefaultGraphicsAPIs(BuildTarget.Android, value);
        }

        public bool MultithreadedRendering
        {
            get => PlayerSettings.MTRendering;
            set => PlayerSettings.MTRendering = value;
        }

        public bool GpuSkinning
        {
            get => PlayerSettings.gpuSkinning;
            set => PlayerSettings.gpuSkinning = value;
        }

        public bool GraphicsJobs
        {
            get => PlayerSettings.graphicsJobs;
            set => PlayerSettings.graphicsJobs = value;
        }

        public bool ProtectGraphicsMemory
        {
            get => PlayerSettings.protectGraphicsMemory;
            set => PlayerSettings.protectGraphicsMemory = value;
        }

        #endregion

        #region Identification

        public string BundleIdentifier
        {
            get => PlayerSettings.GetApplicationIdentifier(BuildTargetGroup.Android);
            set => PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, value);
        }

        public string Version
        {
            get => PlayerSettings.bundleVersion;
            set => PlayerSettings.bundleVersion = value;
        }

        public int BundleVersionCode
        {
            get => PlayerSettings.Android.bundleVersionCode;
            set => PlayerSettings.Android.bundleVersionCode = value;
        }

        public string MinimumApiLevel
        {
            get => PlayerSettings.Android.minSdkVersion.ToString();
            set => PlayerSettings.Android.minSdkVersion = EnumUtils.ParseEnum<AndroidSdkVersions>(value);
        }

        public string TargetSdkVersion
        {
            get => PlayerSettings.Android.targetSdkVersion.ToString();
            set => PlayerSettings.Android.targetSdkVersion = EnumUtils.ParseEnum<AndroidSdkVersions>(value);
        }

        #endregion

        #region Configuration

        public string ScriptingRuntimeVersion
        {
            get => PlayerSettings.scriptingRuntimeVersion.ToString();
            set => PlayerSettings.scriptingRuntimeVersion = EnumUtils.ParseEnum<ScriptingRuntimeVersion>(value);
        }

        public string ScriptingBackend
        {
            get => PlayerSettings.GetScriptingBackend(BuildTargetGroup.Android).ToString();
            set => PlayerSettings.SetScriptingBackend(BuildTargetGroup.Android,
                EnumUtils.ParseEnum<ScriptingImplementation>(value));
        }

        public string ApiCompatibilityLevel
        {
            get => PlayerSettings.GetApiCompatibilityLevel(BuildTargetGroup.Android).ToString();
            set =>
                PlayerSettings.SetApiCompatibilityLevel(BuildTargetGroup.Android,
                    EnumUtils.ParseEnum<ApiCompatibilityLevel>(value));
        }

        public string CppCompilerConfiguration
        {
            get => PlayerSettings.GetIl2CppCompilerConfiguration(BuildTargetGroup.Android).ToString();
            set =>
                PlayerSettings.SetIl2CppCompilerConfiguration(BuildTargetGroup.Android,
                    EnumUtils.ParseEnum<Il2CppCompilerConfiguration>(value));
        }

        public bool MuteOtherAudioSources
        {
            get => PlayerSettings.muteOtherAudioSources;
            set => PlayerSettings.muteOtherAudioSources = value;
        }

        public string Architecture
        {
            get => PlayerSettings.Android.targetArchitectures.ToString();
            set => PlayerSettings.Android.targetArchitectures = EnumUtils.ParseEnum<AndroidArchitecture>(value);
        }

        public string InstallLocation
        {
            get => PlayerSettings.Android.preferredInstallLocation.ToString();
            set => PlayerSettings.Android.preferredInstallLocation =
                EnumUtils.ParseEnum<AndroidPreferredInstallLocation>(value);
        }

        public bool ForceInternetPermission
        {
            get => PlayerSettings.Android.forceInternetPermission;
            set => PlayerSettings.Android.forceInternetPermission = value;
        }

        public bool ForceSdCardPermission
        {
            get => PlayerSettings.Android.forceSDCardPermission;
            set => PlayerSettings.Android.forceSDCardPermission = value;
        }

        public bool AndroidGame
        {
            get => PlayerSettings.Android.androidIsGame;
            set => PlayerSettings.Android.androidIsGame = value;
        }

        public bool AndroidTvCompatibility
        {
            get => PlayerSettings.Android.androidTVCompatibility;
            set => PlayerSettings.Android.androidTVCompatibility = value;
        }

        public string ScriptingDefineSymbols
        {
            get => PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android);
            set => PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, value);
        }

        public bool AllowUnsafeCode
        {
            get => PlayerSettings.allowUnsafeCode;
            set => PlayerSettings.allowUnsafeCode = value;
        }

        #endregion

        #region Optimization

        public bool PrebakeCollisionMeshes
        {
            get => PlayerSettings.bakeCollisionMeshes;
            set => PlayerSettings.bakeCollisionMeshes = value;
        }

        public string AotOptions
        {
            get => PlayerSettings.aotOptions;
            set => PlayerSettings.aotOptions = value;
        }

        public bool StripEngineCode
        {
            get => PlayerSettings.stripEngineCode;
            set => PlayerSettings.stripEngineCode = value;
        }

        #endregion

        #endregion

        #region Android Publishing

        public string KeystoreName
        {
            get => PlayerSettings.Android.keystoreName;
            set => PlayerSettings.Android.keystoreName = value;
        }

        public string KeyaliasName
        {
            get => PlayerSettings.Android.keyaliasName;
            set => PlayerSettings.Android.keyaliasName = value;
        }

        #endregion

    }
}