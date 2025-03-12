using System.Xml.Serialization;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build
{
    [XmlRoot("BuildConfig", Namespace = "http://brutalhack.com/build-config")]
    public class BuildConfig
    {
        public XmlPlayerSettings PlayerSettings = new XmlPlayerSettings();
    }
}