using System;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build
{
    [Serializable]
    public class XmlGeneralPlayerSettings
    {
        public string CompanyName = PlayerSettingsAdapter.General.CompanyName;
        public string ProductName = PlayerSettingsAdapter.General.ProductName;
        public string DefaultIconPath = PlayerSettingsAdapter.General.DefaultIconPath;
        public string DefaultCursorPath = PlayerSettingsAdapter.General.DefaultCursorPath;
        public string Version = PlayerSettingsAdapter.General.Version;
    }
}