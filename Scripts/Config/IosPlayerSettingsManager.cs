using UnityEditor;
using UnityEngine;
using UnityEngine.iOS;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config
{
    public class IosPlayerSettingsManager
    {
        #region iOS Resolution and Presentation 

        public string DefaultOrientation
        {
            get => PlayerSettings.defaultInterfaceOrientation.ToString();
            set => PlayerSettings.defaultInterfaceOrientation = EnumUtils.ParseEnum<UIOrientation>(value);
        }

        public bool UseAnimatedAutorotation
        {
            get => PlayerSettings.useAnimatedAutorotation;
            set => PlayerSettings.useAnimatedAutorotation = value;
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

        public bool RequiresFullscreen
        {
            get => PlayerSettings.iOS.requiresFullScreen;
            set => PlayerSettings.iOS.requiresFullScreen = value;
        }

        public bool StatusBarHidden
        {
            get => PlayerSettings.statusBarHidden;
            set => PlayerSettings.statusBarHidden = value;
        }

        public string StatusBarStyle
        {
            get => PlayerSettings.iOS.statusBarStyle.ToString();
            set => PlayerSettings.iOS.statusBarStyle = EnumUtils.ParseEnum<iOSStatusBarStyle>(value);
        }

        public bool DisableDepthAndStencil
        {
            get => PlayerSettings.iOS.disableDepthAndStencilBuffers;
            set => PlayerSettings.iOS.disableDepthAndStencilBuffers = value;
        }

        public string ShowLoadingIndicator
        {
            get => PlayerSettings.iOS.showActivityIndicatorOnLoading.ToString();
            set => PlayerSettings.iOS.showActivityIndicatorOnLoading = EnumUtils.ParseEnum<iOSShowActivityIndicatorOnLoading>(value);
        }

        #endregion

        #region iOS Other

        #region Rendering

        public string ColorSpace
        {
            get => PlayerSettings.colorSpace.ToString();
            set => PlayerSettings.colorSpace = EnumUtils.ParseEnum<ColorSpace>(value);
        }

        public bool AutoGraphicsApi
        {
            get => PlayerSettings.GetUseDefaultGraphicsAPIs(BuildTarget.iOS);
            set => PlayerSettings.SetUseDefaultGraphicsAPIs(BuildTarget.iOS, value);
        }

        public bool MetalApiValidation
        {
            get => PlayerSettings.enableMetalAPIValidation;
            set => PlayerSettings.enableMetalAPIValidation = value;
        }

        public bool ForceHardShadowsOnMetal
        {
            get => PlayerSettings.iOS.forceHardShadowsOnMetal;
            set => PlayerSettings.iOS.forceHardShadowsOnMetal = value;
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

        #endregion

        #region Identification

        public string BundleIdentifier
        {
            get => PlayerSettings.GetApplicationIdentifier(BuildTargetGroup.iOS);
            set => PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.iOS, value);
        }

        public string Version
        {
            get => PlayerSettings.bundleVersion;
            set => PlayerSettings.bundleVersion = value;
        }

        public string Build
        {
            get => PlayerSettings.iOS.buildNumber;
            set => PlayerSettings.iOS.buildNumber = value;
        }

        public string SigningTeamId
        {
            get => PlayerSettings.iOS.appleDeveloperTeamID;
            set => PlayerSettings.iOS.appleDeveloperTeamID = value;
        }

        public bool AutomaticallySign
        {
            get => PlayerSettings.iOS.appleEnableAutomaticSigning;
            set => PlayerSettings.iOS.appleEnableAutomaticSigning = value;
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
            get => PlayerSettings.GetScriptingBackend(BuildTargetGroup.iOS).ToString();
            set => PlayerSettings.SetScriptingBackend(BuildTargetGroup.iOS, EnumUtils.ParseEnum<ScriptingImplementation>(value));
        }

        public string ApiCompatibilityLevel
        {
            get => PlayerSettings.GetApiCompatibilityLevel(BuildTargetGroup.iOS).ToString();
            set => PlayerSettings.SetApiCompatibilityLevel(BuildTargetGroup.iOS, EnumUtils.ParseEnum<ApiCompatibilityLevel>(value));
        }

        public bool UseOnDemandResources
        {
            get => PlayerSettings.iOS.useOnDemandResources;
            set => PlayerSettings.iOS.useOnDemandResources = value;
        }

        public int AccelerometerFrequency
        {
            get => PlayerSettings.accelerometerFrequency;
            set => PlayerSettings.accelerometerFrequency = value;
        }

        public string CameraUsageDescription
        {
            get => PlayerSettings.iOS.cameraUsageDescription;
            set => PlayerSettings.iOS.cameraUsageDescription = value;
        }

        public string LocationUsageDescription
        {
            get => PlayerSettings.iOS.locationUsageDescription;
            set => PlayerSettings.iOS.locationUsageDescription = value;
        }

        public string MicrophoneUsageDescription
        {
            get => PlayerSettings.iOS.microphoneUsageDescription;
            set => PlayerSettings.iOS.microphoneUsageDescription = value;
        }

        public bool MuteOtherAudioSources
        {
            get => PlayerSettings.muteOtherAudioSources;
            set => PlayerSettings.muteOtherAudioSources = value;
        }

        public bool RequiresPersistentWifi
        {
            get => PlayerSettings.iOS.requiresPersistentWiFi;
            set => PlayerSettings.iOS.requiresPersistentWiFi = value;
        }

        public bool AllowDownloadsOverHttp
        {
            get => PlayerSettings.iOS.allowHTTPDownload;
            set => PlayerSettings.iOS.allowHTTPDownload = value;
        }

        public string TargetDevice
        {
            get => PlayerSettings.iOS.targetDevice.ToString();
            set => PlayerSettings.iOS.targetDevice = EnumUtils.ParseEnum<iOSTargetDevice>(value);
        }

        public string TargetSdk
        {
            get => PlayerSettings.iOS.sdkVersion.ToString();
            set => PlayerSettings.iOS.sdkVersion = EnumUtils.ParseEnum<iOSSdkVersion>(value);
        }

        public string TargetMinimumIosSdk
        {
            get => PlayerSettings.iOS.targetOSVersionString;
            set => PlayerSettings.iOS.targetOSVersionString = value;
        }

        public string DeferSystemGesturesMode
        {
            get => PlayerSettings.iOS.deferSystemGesturesMode.ToString();
            set => PlayerSettings.iOS.deferSystemGesturesMode = EnumUtils.ParseEnum<SystemGestureDeferMode>(value);
        }

        public bool HideHomeButtonOnIphoneX
        {
            get => PlayerSettings.iOS.hideHomeButton;
            set => PlayerSettings.iOS.hideHomeButton = value;
        }

        public string BehaviorInBackground
        {
            get => PlayerSettings.iOS.appInBackgroundBehavior.ToString();
            set => PlayerSettings.iOS.appInBackgroundBehavior = EnumUtils.ParseEnum<iOSAppInBackgroundBehavior>(value);
        }

        public int Architecture
        {
            get => PlayerSettings.GetArchitecture(BuildTargetGroup.iOS);
            set => PlayerSettings.SetArchitecture(BuildTargetGroup.iOS, value);
        }

        public string ScriptingDefineSymbols
        {
            get => PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.iOS);
            set => PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iOS, value);
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

        public string ScriptCallOptimization
        {
            get => PlayerSettings.iOS.scriptCallOptimization.ToString();
            set => PlayerSettings.iOS.scriptCallOptimization = EnumUtils.ParseEnum<ScriptCallOptimizationLevel>(value);
        }

        #endregion

        #endregion

    }
}