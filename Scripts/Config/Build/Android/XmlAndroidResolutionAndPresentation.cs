using System;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build.Android
{
    [Serializable]
    public class XmlAndroidResolutionAndPresentation
    {
        public bool PreserveFramebufferAlpha = PlayerSettingsAdapter.Android.PreserveFramebufferAlpha;
        public string BlitType = PlayerSettingsAdapter.Android.BlitType;
        

        public string DefaultOrientation = PlayerSettingsAdapter.Android.DefaultOrientation;
        public bool AllowedAutorotateToPortrait = PlayerSettingsAdapter.Android.AllowedAutorotateToPortrait;
        public bool AllowedAutorotateToLandscapeLeft = PlayerSettingsAdapter.Android.AllowedAutorotateToLandscapeLeft;
        public bool AllowedAutorotateToLandscapeRight = PlayerSettingsAdapter.Android.AllowedAutorotateToLandscapeRight;
        public bool AllowedAutorotateToPortraitUpsideDown = PlayerSettingsAdapter.Android.AllowedAutorotateToPortraitUpsideDown;

        public bool Use32BitDisplayBuffer = PlayerSettingsAdapter.Android.Use32BitDisplayBuffer;

        public bool DisableDepthAndStencil = PlayerSettingsAdapter.Android.DisableDepthAndStencil;
        public string ShowLoadingIndicator = PlayerSettingsAdapter.Android.ShowLoadingIndicator;
    }
}