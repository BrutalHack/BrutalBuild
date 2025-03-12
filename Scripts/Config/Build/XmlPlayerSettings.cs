using System;
using BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build.Android;
using BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build.Ios;
using BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build.Standalone;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build
{
    [Serializable]
    public class XmlPlayerSettings
    {
        public XmlGeneralPlayerSettings General = new XmlGeneralPlayerSettings();
        public XmlStandalonePlayerSettings Standalone = new XmlStandalonePlayerSettings();
        public XmlIosPlayerSettings Ios = new XmlIosPlayerSettings();
        public XmlAndroidPlayerSettings Android = new XmlAndroidPlayerSettings();
    }
}