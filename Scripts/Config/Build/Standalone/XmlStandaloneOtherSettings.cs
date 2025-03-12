using System;
using UnityEditor;
using UnityEngine;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build.Standalone
{
    [Serializable]
    public class XmlStandaloneOtherSettings
    {
        // Rendering
        public string ColorSpace = PlayerSettingsAdapter.Standalone.ColorSpace;
        public bool AutoGraphicsApiWindows = PlayerSettingsAdapter.Standalone.AutoGraphicsApiWindows;
        public bool AutoGraphicsApiMac = PlayerSettingsAdapter.Standalone.AutoGraphicsApiMac;
        public bool AutoGraphicsApiLinux = PlayerSettingsAdapter.Standalone.AutoGraphicsApiLinux;
        public bool EnableMetalApiValidation = PlayerSettingsAdapter.Standalone.EnableMetalApiValidation;
        public bool GraphicsJobs = PlayerSettingsAdapter.Standalone.GraphicsJobs;
        public bool GpuSkinning = PlayerSettingsAdapter.Standalone.GpuSkinning;
        public bool EnableFrameTimingStats = PlayerSettingsAdapter.Standalone.EnableFrameTimingStats;
        public bool UseHdrDisplay = PlayerSettingsAdapter.Standalone.UseHdrDisplay;
        public string HdrSwapChainBitDepth = PlayerSettingsAdapter.Standalone.HdrSwapChainBitDepth;
        public bool EnableVirtualTexturing = PlayerSettingsAdapter.Standalone.EnableVirtualTexturing;
        public string ShaderPrecisionModel = PlayerSettingsAdapter.Standalone.ShaderPrecisionModel;

        // VulkanSettings
        public bool EnableVulkanSrgbWrite = PlayerSettingsAdapter.Standalone.EnableVulkanSrgbWrite;
        public uint VulkanNumberOfSwapChainBuffers = PlayerSettingsAdapter.Standalone.VulkanNumberOfSwapChainBuffers;
        public bool VulkanLateAcquireSwapchainImage = PlayerSettingsAdapter.Standalone.VulkanLateAcquireSwapchainImage;

        // Mac App Store
        public string BundleIdentifier = PlayerSettingsAdapter.Standalone.BundleIdentifier;
        public string Build = PlayerSettingsAdapter.Standalone.Build;
        public bool UseMacAppStoreValidation = PlayerSettingsAdapter.Standalone.UseMacAppStoreValidation;

        // Configuration
        public string ScriptingBackend = PlayerSettingsAdapter.Standalone.ScriptingBackend;
        public string ApiCompatibilityLevel = PlayerSettingsAdapter.Standalone.ApiCompatibilityLevel;
        public string CppCompilerConfiguration = PlayerSettingsAdapter.Standalone.CppCompilerConfiguration;
        public bool IncrementalGc = PlayerSettingsAdapter.Standalone.IncrementalGc;
        public bool MonoAssemblyVersionValidation = PlayerSettingsAdapter.Standalone.MonoAssemblyVersionValidation;

        //Script Compilation
        public string ScriptingDefineSymbols = PlayerSettingsAdapter.Standalone.ScriptingDefineSymbols;
        public string[] AdditionalCompilerArguments = PlayerSettingsAdapter.Standalone.AdditionalCompilerArguments;
        public bool SuppressCommonWarnings = PlayerSettingsAdapter.Standalone.SuppressCommonWarnings;
        public bool AllowUnsafeCode = PlayerSettingsAdapter.Standalone.AllowUnsafeCode;

        // Optimization
        public bool PrebakeCollisionMeshes = PlayerSettingsAdapter.Standalone.PrebakeCollisionMeshes;
        public string ManagedStrippingLevel = PlayerSettingsAdapter.Standalone.ManagedStrippingLevel;
        public bool StripUnusedMeshComponents = PlayerSettingsAdapter.Standalone.StripUnusedMeshComponents;
        public bool StripEngineCode = PlayerSettingsAdapter.Standalone.StripEngineCode;
        
        // Stack Trace
        public string ErrorStackTrace = PlayerSettingsAdapter.Standalone.ErrorStackTrace;
        public string AssertStackTrace = PlayerSettingsAdapter.Standalone.AssertStackTrace;
        public string WarningStackTrace = PlayerSettingsAdapter.Standalone.WarningStackTrace;
        public string LogStackTrace = PlayerSettingsAdapter.Standalone.LogStackTrace;
        public string ExceptionStackTrace = PlayerSettingsAdapter.Standalone.ExceptionStackTrace;

    }
}