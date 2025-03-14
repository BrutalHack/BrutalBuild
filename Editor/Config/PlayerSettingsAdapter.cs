using System;
using System.Linq;
using BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build;
using UnityEngine;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config
{
    public static class PlayerSettingsAdapter
    {
        public static readonly GeneralPlayerSettingsAdapter General = new GeneralPlayerSettingsAdapter();
        public static readonly StandalonePlayerSettingsAdapter Standalone = new StandalonePlayerSettingsAdapter();
        public static readonly IosPlayerSettingsAdapter Ios = new IosPlayerSettingsAdapter();
        public static readonly AndroidPlayerSettingsAdapter Android = new AndroidPlayerSettingsAdapter();

        public static void Import(XmlPlayerSettings xmlPlayerSettings)
        {
            CopyFieldsToProperties(xmlPlayerSettings.General, General);
            CopyFieldsToProperties(xmlPlayerSettings.Standalone.ResolutionAndPresentation, Standalone);
            CopyFieldsToProperties(xmlPlayerSettings.Standalone.OtherSettings, Standalone);
            CopyFieldsToProperties(xmlPlayerSettings.Ios.ResolutionAndPresentation, Ios);
            CopyFieldsToProperties(xmlPlayerSettings.Ios.OtherSettings, Ios);
            CopyFieldsToProperties(xmlPlayerSettings.Android.ResolutionAndPresentation, Android);
            CopyFieldsToProperties(xmlPlayerSettings.Android.OtherSettings, Android);
            CopyFieldsToProperties(xmlPlayerSettings.Android.PublishingSettings, Android);
        }

        private static void CopyFieldsToProperties(object source, object target)
        {
            foreach (var sourceField in source.GetType().GetFields())
            {
                try
                {
                    var targetProperty = target.GetType().GetProperties().Single(
                        property => property.Name.Equals(sourceField.Name)
                    );
                    targetProperty.SetValue(target, sourceField.GetValue(source));
                }
                catch (Exception)
                {
                    Debug.Log("Failed to Import Field " + source.GetType() + "->" + sourceField +
                              " to " + target.GetType());
                    throw;
                }
            }
        }
    }
}