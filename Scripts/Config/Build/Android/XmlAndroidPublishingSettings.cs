using System;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build.Android
{
    [Serializable]
    public class XmlAndroidPublishingSettings
    {
        public string KeystoreName = PlayerSettingsAdapter.Android.KeystoreName;
        
        public string KeyaliasName = PlayerSettingsAdapter.Android.KeyaliasName;
    }
}