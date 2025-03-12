using System;
using UnityEditor;
using UnityEngine;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build.Standalone
{
    [Serializable]
    public class XmlStandaloneResolutionAndPresentation
    {
        public FullScreenMode FullscreenMode = PlayerSettingsAdapter.Standalone.FullscreenMode;
        public bool DefaultIsNativeResolution = PlayerSettingsAdapter.Standalone.DefaultIsNativeResolution;
        public bool MacRetinaSupport = PlayerSettingsAdapter.Standalone.MacRetinaSupport;
        public bool RunInBackground = PlayerSettingsAdapter.Standalone.RunInBackground;
        public bool CaptureSingleScreen = PlayerSettingsAdapter.Standalone.CaptureSingleScreen;
        public bool UsePlayerLog = PlayerSettingsAdapter.Standalone.UsePlayerLog;
        public bool ResizableWindow = PlayerSettingsAdapter.Standalone.ResizableWindow;
        public bool VisibleInBackground = PlayerSettingsAdapter.Standalone.VisibleInBackground;
        public bool AllowFullscreenSwitch = PlayerSettingsAdapter.Standalone.AllowFullscreenSwitch;
        public bool ForceSingleInstance = PlayerSettingsAdapter.Standalone.ForceSingleInstance;
        public AspectRatio[] SupportedAspectRatios = PlayerSettingsAdapter.Standalone.SupportedAspectRatios;
    }
}