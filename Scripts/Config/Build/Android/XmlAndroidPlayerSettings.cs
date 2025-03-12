using System;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build.Android
{
    [Serializable]
    public class XmlAndroidPlayerSettings
    {
        public XmlAndroidResolutionAndPresentation ResolutionAndPresentation = new XmlAndroidResolutionAndPresentation();
        public XmlAndroidOtherSettings OtherSettings = new XmlAndroidOtherSettings();
        public XmlAndroidPublishingSettings PublishingSettings = new XmlAndroidPublishingSettings();
        public XmlAndroidXrSettings XrSettings = new XmlAndroidXrSettings();
    }
}