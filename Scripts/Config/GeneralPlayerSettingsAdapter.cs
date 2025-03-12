using System.Linq;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config
{
    public class GeneralPlayerSettingsAdapter
    {
        public string DefaultIconPath
        {
            get
            {
                var texture2D = PlayerSettings.GetIcons(NamedBuildTarget.Unknown, IconKind.Any).FirstOrDefault();
                return texture2D != null ? AssetDatabase.GetAssetPath(texture2D) : null;
            }
            set
            {
                var icon = AssetDatabase.LoadAssetAtPath<Texture2D>(value);
                PlayerSettings.SetIcons(NamedBuildTarget.Unknown, new[] {icon}, IconKind.Any);
            }
        }

        public string DefaultCursorPath
        {
            get
            {
                var texture2D = PlayerSettings.defaultCursor;
                return texture2D != null ? AssetDatabase.GetAssetPath(texture2D) : null;
            }
            set
            {
                var cursor = AssetDatabase.LoadAssetAtPath<Texture2D>(value);
                PlayerSettings.defaultCursor = cursor;
            }
        }

        public string CompanyName
        {
            get => PlayerSettings.companyName;
            set => PlayerSettings.companyName = value;
        }

        public string ProductName
        {
            get => PlayerSettings.productName;
            set => PlayerSettings.productName = value;
        }
        
        public string Version
        {
            get => PlayerSettings.bundleVersion;
            set => PlayerSettings.bundleVersion = value;
        }
    }
}