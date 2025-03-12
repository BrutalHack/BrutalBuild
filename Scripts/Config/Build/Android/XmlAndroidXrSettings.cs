namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build.Android
{
    public class XmlAndroidXrSettings
    {
        public bool VirtualRealitySupported = PlayerSettingsAdapter.Android.VirtualRealitySupported;
        public string[] VirtualRealitySdks = PlayerSettingsAdapter.Android.VirtualRealitySdks;
        public int CardboardDepthFormat = PlayerSettingsAdapter.Android.CardboardDepthFormat;
        public int DaydreamDepthFormat = PlayerSettingsAdapter.Android.DaydreamDepthFormat;
        public bool DaydreamEnableVideoSurface = PlayerSettingsAdapter.Android.DaydreamEnableVideoSurface;

        public bool DaydreamEnableVideoSurfaceProtectedMemory =
            PlayerSettingsAdapter.Android.DaydreamEnableVideoSurfaceProtectedMemory;

        public string DaydreamMaximumSupportedHeadTracking =
            PlayerSettingsAdapter.Android.DaydreamMaximumSupportedHeadTracking;

        public string DaydreamMinimumSupportedHeadTracking =
            PlayerSettingsAdapter.Android.DaydreamMinimumSupportedHeadTracking;
        
        public string StereoRenderingMethod = PlayerSettingsAdapter.Android.StereoRenderingMethod;
    }
}