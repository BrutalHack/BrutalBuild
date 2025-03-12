using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.iOS;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config
{
    public class StandalonePlayerSettingsAdapter
    {
        #region Standalone Icon

        public Texture2D[] Icon
        {
            get => PlayerSettings.GetIconsForTargetGroup(BuildTargetGroup.Standalone);
            set => PlayerSettings.SetIconsForTargetGroup(BuildTargetGroup.Standalone, value);
        }

        #endregion

        #region Standalone Resolution and Presentation

        public FullScreenMode FullscreenMode
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
            get => PlayerSettings.GetUseDefaultGraphicsAPIs(BuildTarget.StandaloneWindows64);
            set => PlayerSettings.SetUseDefaultGraphicsAPIs(BuildTarget.StandaloneWindows64, value);
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

        public bool EnableMetalApiValidation
        {
            get => PlayerSettings.enableMetalAPIValidation;
            set => PlayerSettings.enableMetalAPIValidation = value;
        }

        public bool GpuSkinning
        {
            get => PlayerSettings.gpuSkinning;
            set => PlayerSettings.gpuSkinning = value;
        }

        public bool UseHdrDisplay
        {
            get => PlayerSettings.useHDRDisplay;
            set => PlayerSettings.useHDRDisplay = value;
        }

        public string HdrSwapChainBitDepth
        {
            get => PlayerSettings.D3DHDRBitDepth.ToString();
            set => PlayerSettings.D3DHDRBitDepth = EnumUtils.ParseEnum<D3DHDRDisplayBitDepth>(value);
        }

        public bool EnableVirtualTexturing
        {
            get => PlayerSettings.GetVirtualTexturingSupportEnabled();
            set => PlayerSettings.SetVirtualTexturingSupportEnabled(value);
        }

        public string ShaderPrecisionModel
        {
            get => PlayerSettings.GetShaderPrecisionModel().ToString();
            set => EnumUtils.ParseEnum<ShaderPrecisionModel>(value);
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

        #endregion

        #region Vulkan Settings

        public bool EnableVulkanSrgbWrite
        {
            get => PlayerSettings.vulkanEnableSetSRGBWrite;
            set => PlayerSettings.vulkanEnableSetSRGBWrite = value;
        }

        public uint VulkanNumberOfSwapChainBuffers
        {
            get => PlayerSettings.vulkanNumSwapchainBuffers;
            set => PlayerSettings.vulkanNumSwapchainBuffers = value;
        }

        public bool VulkanLateAcquireSwapchainImage
        {
            get => PlayerSettings.vulkanEnableLateAcquireNextImage;
            set => PlayerSettings.vulkanEnableLateAcquireNextImage = value;
        }

        #endregion

        #region Mac App Store Options

        public string BundleIdentifier
        {
            get => PlayerSettings.GetApplicationIdentifier(BuildTargetGroup.Standalone);
            set => PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Standalone, value);
        }

        public string Build
        {
            get => PlayerSettings.macOS.buildNumber;
            set => PlayerSettings.macOS.buildNumber = value;
        }

        public bool UseMacAppStoreValidation
        {
            get => PlayerSettings.useMacAppStoreValidation;
            set => PlayerSettings.useMacAppStoreValidation = value;
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
            get => PlayerSettings.GetIl2CppCompilerConfiguration(BuildTargetGroup.Standalone).ToString();
            set =>
                PlayerSettings.SetIl2CppCompilerConfiguration(BuildTargetGroup.Standalone,
                    EnumUtils.ParseEnum<Il2CppCompilerConfiguration>(value));
        }

        public bool IncrementalGc
        {
            get => PlayerSettings.gcIncremental;
            set => PlayerSettings.gcIncremental = value;
        }

        public bool MonoAssemblyVersionValidation
        {
            get => PlayerSettings.assemblyVersionValidation;
            set => PlayerSettings.assemblyVersionValidation = value;
        }

        #endregion

        #region Script Compilation

        public string ScriptingDefineSymbols
        {
            get => PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone);
            set => PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone, value);
        }

        public string[] AdditionalCompilerArguments
        {
            get => PlayerSettings.GetAdditionalCompilerArgumentsForGroup(BuildTargetGroup.Standalone);
            set => PlayerSettings.SetAdditionalCompilerArgumentsForGroup(BuildTargetGroup.Standalone, value);
        }

        public bool SuppressCommonWarnings
        {
            get => PlayerSettings.suppressCommonWarnings;
            set => PlayerSettings.suppressCommonWarnings = value;
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

        public string ManagedStrippingLevel
        {
            get => PlayerSettings.GetManagedStrippingLevel(BuildTargetGroup.Standalone).ToString();
            set => PlayerSettings.SetManagedStrippingLevel(BuildTargetGroup.Standalone,
                EnumUtils.ParseEnum<ManagedStrippingLevel>(value));
        }

        public bool StripUnusedMeshComponents
        {
            get => PlayerSettings.stripUnusedMeshComponents;
            set => PlayerSettings.stripUnusedMeshComponents = value;
        }

        public bool StripEngineCode
        {
            get => PlayerSettings.stripEngineCode;
            set => PlayerSettings.stripEngineCode = value;
        }

        #endregion

        #region Stack Trace

        public string ErrorStackTrace
        {
            get => PlayerSettings.GetStackTraceLogType(LogType.Error).ToString();
            set => PlayerSettings.SetStackTraceLogType(LogType.Error, EnumUtils.ParseEnum<StackTraceLogType>(value));
        }

        public string AssertStackTrace
        {
            get => PlayerSettings.GetStackTraceLogType(LogType.Assert).ToString();
            set => PlayerSettings.SetStackTraceLogType(LogType.Assert, EnumUtils.ParseEnum<StackTraceLogType>(value));
        }

        public string WarningStackTrace
        {
            get => PlayerSettings.GetStackTraceLogType(LogType.Warning).ToString();
            set => PlayerSettings.SetStackTraceLogType(LogType.Warning, EnumUtils.ParseEnum<StackTraceLogType>(value));
        }

        public string LogStackTrace
        {
            get => PlayerSettings.GetStackTraceLogType(LogType.Log).ToString();
            set => PlayerSettings.SetStackTraceLogType(LogType.Log, EnumUtils.ParseEnum<StackTraceLogType>(value));
        }

        public string ExceptionStackTrace
        {
            get => PlayerSettings.GetStackTraceLogType(LogType.Exception).ToString();
            set =>
                PlayerSettings.SetStackTraceLogType(LogType.Exception, EnumUtils.ParseEnum<StackTraceLogType>(value));
        }

        #endregion

        #endregion
    }
}