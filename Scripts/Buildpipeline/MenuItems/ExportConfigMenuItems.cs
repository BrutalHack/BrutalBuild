using BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build;
using UnityEditor;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.MenuItems
{
    public class ExportConfigMenuItems
    {
        /// <summary>
        /// Exports the current AppConfig file to the BuildResources directory
        /// </summary>
        [MenuItem("BrutalHack/Export Config/App Config")]
        public static void GenerateSampleAppConfig()
        {
            BuildController.ExportConfig<AppConfig>();
        }

        /// <summary>
        /// Exports the current BuildConfig file to the BuildResources directory
        /// </summary>
        [MenuItem("BrutalHack/Export Config/Build Config")]
        public static void GenerateSampleBuildConfig()
        {
            BuildController.ExportConfig<BuildConfig>();
        }
    }
}