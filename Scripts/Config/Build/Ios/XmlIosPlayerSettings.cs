using System;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build.Ios
{
    [Serializable]
    public class XmlIosPlayerSettings
    {
        public XmlIosResolutionAndPresentation ResolutionAndPresentation = new XmlIosResolutionAndPresentation();
        public XmlIosOtherSettings OtherSettings = new XmlIosOtherSettings();
    }
}