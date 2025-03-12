namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build.Ios
{
    public class XmlIosXrSettings
    {
        public bool VirtualRealitySupported = PlayerSettingsAdapter.Ios.VirtualRealitySupported;
        public string[] VirtualRealitySdks = PlayerSettingsAdapter.Ios.VirtualRealitySdks;
        public int CardboardDepthFormat = PlayerSettingsAdapter.Ios.CardboardDepthFormat;
        public string StereoRenderingMethod = PlayerSettingsAdapter.Ios.StereoRenderingMethod;
    }
}