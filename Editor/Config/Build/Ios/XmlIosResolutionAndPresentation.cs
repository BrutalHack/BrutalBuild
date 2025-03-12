using System;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build.Ios
{
    [Serializable]
    public class XmlIosResolutionAndPresentation
    {
        public string DefaultOrientation = PlayerSettingsAdapter.Ios.DefaultOrientation;
        public bool UseAnimatedAutorotation = PlayerSettingsAdapter.Ios.UseAnimatedAutorotation;
        public bool AllowedAutorotateToPortrait = PlayerSettingsAdapter.Ios.AllowedAutorotateToPortrait;
        public bool AllowedAutorotateToLandscapeLeft = PlayerSettingsAdapter.Ios.AllowedAutorotateToLandscapeLeft;
        public bool AllowedAutorotateToLandscapeRight = PlayerSettingsAdapter.Ios.AllowedAutorotateToLandscapeRight;
        public bool AllowedAutorotateToPortraitUpsideDown = PlayerSettingsAdapter.Ios.AllowedAutorotateToPortraitUpsideDown;
        
        public bool RequiresFullscreen = PlayerSettingsAdapter.Ios.RequiresFullscreen;
        public bool StatusBarHidden = PlayerSettingsAdapter.Ios.StatusBarHidden;
        public string StatusBarStyle = PlayerSettingsAdapter.Ios.StatusBarStyle;
        public bool DisableDepthAndStencil = PlayerSettingsAdapter.Ios.DisableDepthAndStencil;
        public string ShowLoadingIndicator = PlayerSettingsAdapter.Ios.ShowLoadingIndicator;
    }
}