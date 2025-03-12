using System;
using BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build.Android;
using BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build.Ios;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build
{
    [Serializable]
    public class XmlPlayerSettings
    {
        public XmlGeneralPlayerSettings General = new XmlGeneralPlayerSettings();
        public XmlIosPlayerSettings Ios = new XmlIosPlayerSettings();
        public XmlAndroidPlayerSettings Android = new XmlAndroidPlayerSettings();
    }
}