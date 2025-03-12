using BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.Enums;
using UnityEditor;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.MenuItems
{
    public static class ChangeContextMenuItems
    {
        #region General

        [MenuItem(BuildMenuLabels.ChangeContextReleaseDevDebug)]
        public static void ChangeContextGeneralDev()
        {
            BuildController.SetContext(AppContext.Standalone, Environment.Dev);
        }


        [MenuItem(BuildMenuLabels.ChangeContextReleaseProdDebug)]
        public static void ChangeContextGeneralProd()
        {
            BuildController.SetContext(AppContext.Standalone, Environment.Prod);
        }

        #endregion
        
        #region Steam

        [MenuItem(BuildMenuLabels.ChangeContextReleaseSteamDevDebug)]
        public static void ChangeContextSteamDev()
        {
            BuildController.SetContext(AppContext.Steam, Environment.Dev);
        }


        [MenuItem(BuildMenuLabels.ChangeContextReleaseSteamProdDebug)]
        public static void ChangeContextSteamProd()
        {
            BuildController.SetContext(AppContext.Steam, Environment.Prod);
        }

        #endregion

    }
}