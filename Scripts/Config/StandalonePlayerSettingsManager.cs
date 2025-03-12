using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.iOS;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config
{
    //TODO implement xml serialization
    public class StandalonePlayerSettingsManager
    {
        #region Standalone Icon

        public Texture2D[] Icon
        {
            get => PlayerSettings.GetIconsForTargetGroup(BuildTargetGroup.Standalone);
            set => PlayerSettings.SetIconsForTargetGroup(BuildTargetGroup.Standalone, value);
        }

        #endregion

        #region Standalone Resolution and Presentation

        public FullScreenMode FullScreenMode
        {
            get => PlayerSettings.fullScreenMode;
            set => PlayerSettings.fullScreenMode = value;
        }

        public bool DefaultIsNativeResolution
        {
            get => PlayerSettings.defaultIsNativeResolution;
            set => PlayerSettings.defaultIsNativeResolution = value;
        }

        public int DefaultScreenWidth
        {
            get => PlayerSettings.defaultScreenWidth;
            set => PlayerSettings.defaultScreenWidth = value;
        }

        public int DefaultScreenHeight
        {
            get => PlayerSettings.defaultScreenHeight;
            set => PlayerSettings.defaultScreenHeight = value;
        }

        public bool MacRetinaSupport
        {
            get => PlayerSettings.macRetinaSupport;
            set => PlayerSettings.macRetinaSupport = value;
        }

        public bool RunInBackground
        {
            get => PlayerSettings.runInBackground;
            set => PlayerSettings.runInBackground = value;
        }

        public bool CaptureSingleScreen
        {
            get => PlayerSettings.captureSingleScreen;
            set => PlayerSettings.captureSingleScreen = value;
        }

        public bool UsePlayerLog
        {
            get => PlayerSettings.usePlayerLog;
            set => PlayerSettings.usePlayerLog = value;
        }

        public bool ResizableWindow
        {
            get => PlayerSettings.resizableWindow;
            set => PlayerSettings.resizableWindow = value;
        }

        public bool VisibleInBackground
        {
            get => PlayerSettings.visibleInBackground;
            set => PlayerSettings.visibleInBackground = value;
        }

        public bool AllowFullscreenSwitch
        {
            get => PlayerSettings.allowFullscreenSwitch;
            set => PlayerSettings.allowFullscreenSwitch = value;
        }

        public bool ForceSingleInstance
        {
            get => PlayerSettings.forceSingleInstance;
            set => PlayerSettings.forceSingleInstance = value;
        }

        public bool UseDxgiFlipModelSwapchainForD3d11
        {
            get => PlayerSettings.useFlipModelSwapchain;
            set => PlayerSettings.useFlipModelSwapchain = value;
        }

        public AspectRatio[] SupportedAspectRatios
        {
            get
            {
                var allAspectRatios = (AspectRatio[]) Enum.GetValues(typeof(AspectRatio));
                return allAspectRatios
                    .Where(PlayerSettings.HasAspectRatio)
                    .ToArray();
            }
            set
            {
                var allAspectRatios = (AspectRatio[]) Enum.GetValues(typeof(AspectRatio));
                foreach (var aspectRatio in allAspectRatios)
                {
                    PlayerSettings.SetAspectRatio(aspectRatio, value.Contains(aspectRatio));
                }
            }
        }

        #endregion

        #region Standalone Other

        #region Rendering

        public string ColorSpace
        {
            get => PlayerSettings.colorSpace.ToString();
            set => PlayerSettings.colorSpace = EnumUtils.ParseEnum<ColorSpace>(value);
        }

        public bool AutoGraphicsApiWindows
        {
            get => PlayerSettings.GetUseDefaultGraphicsAPIs(BuildTarget.StandaloneWindows);
            set => PlayerSettings.SetUseDefaultGraphicsAPIs(BuildTarget.StandaloneWindows, value);
        }

        public bool AutoGraphicsApiMac
        {
            get => PlayerSettings.GetUseDefaultGraphicsAPIs(BuildTarget.StandaloneOSX);
            set => PlayerSettings.SetUseDefaultGraphicsAPIs(BuildTarget.StandaloneOSX, value);
        }

        public bool AutoGraphicsApiLinux
        {
            get => PlayerSettings.GetUseDefaultGraphicsAPIs(BuildTarget.StandaloneLinux64);
            set => PlayerSettings.SetUseDefaultGraphicsAPIs(BuildTarget.StandaloneLinux64, value);
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

        public bool EnableFrameTimingStats
        {
            get => PlayerSettings.enableFrameTimingStats;
            set => PlayerSettings.enableFrameTimingStats = value;
        }

        public bool ProtectGraphicsMemory
        {
            get => PlayerSettings.protectGraphicsMemory;
            set => PlayerSettings.protectGraphicsMemory = value;
        }

        #endregion

        #region Mac App Store Options

        public string BundleIdentifier
        {
            get => PlayerSettings.GetApplicationIdentifier(BuildTargetGroup.Standalone);
            set => PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Standalone, value);
        }

        public bool UseMacAppStoreValidation
        {
            get => PlayerSettings.useMacAppStoreValidation;
            set => PlayerSettings.useMacAppStoreValidation = value;
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

        #endregion

        #region Configuration

        public string ScriptingBackend
        {
            get => PlayerSettings.GetScriptingBackend(BuildTargetGroup.Standalone).ToString();
            set => PlayerSettings.SetScriptingBackend(BuildTargetGroup.Standalone,
                EnumUtils.ParseEnum<ScriptingImplementation>(value));
        }

        public string ApiCompatibilityLevel
        {
            get => PlayerSettings.GetApiCompatibilityLevel(BuildTargetGroup.Standalone).ToString();
            set => PlayerSettings.SetApiCompatibilityLevel(BuildTargetGroup.Standalone,
                EnumUtils.ParseEnum<ApiCompatibilityLevel>(value));
        }

        public string CppCompilerConfiguration
        {
            get => PlayerSettings.GetIl2CppCompilerConfiguration(BuildTargetGroup.Android).ToString();
            set =>
                PlayerSettings.SetIl2CppCompilerConfiguration(BuildTargetGroup.Android,
                    EnumUtils.ParseEnum<Il2CppCompilerConfiguration>(value));
        }

        public string IncrementalIl2CppBuild
        {
            get => PlayerSettings.GetIncrementalIl2CppBuild(BuildTargetGroup.Standalone).ToString();
            set => PlayerSettings.SetIl2CppCompilerConfiguration(BuildTargetGroup.Standalone,
                EnumUtils.ParseEnum<Il2CppCompilerConfiguration>(value));
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

        public bool StripEngineCode
        {
            get => PlayerSettings.stripEngineCode;
            set => PlayerSettings.stripEngineCode = value;
        }

        #endregion

        #endregion
    }
}