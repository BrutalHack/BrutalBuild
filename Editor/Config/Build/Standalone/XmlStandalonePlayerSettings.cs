using System;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build.Standalone
{
    [Serializable]
    public class XmlStandalonePlayerSettings
    {
        public XmlStandaloneResolutionAndPresentation ResolutionAndPresentation = new XmlStandaloneResolutionAndPresentation();
        public XmlStandaloneOtherSettings OtherSettings = new XmlStandaloneOtherSettings();
    }
}