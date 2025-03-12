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
            BuildController.SetContext(AppContext.Release, Environment.Dev);
        }


        [MenuItem(BuildMenuLabels.ChangeContextReleaseProdDebug)]
        public static void ChangeContextGeneralProd()
        {
            BuildController.SetContext(AppContext.Release, Environment.Prod);
        }

        #endregion

        #region Demo

        [MenuItem(BuildMenuLabels.ChangeContextDemoDevDebug)]
        public static void ChangeContextDemoDev()
        {
            BuildController.SetContext(AppContext.Demo, Environment.Dev);
        }


        [MenuItem(BuildMenuLabels.ChangeContextDemoProdDebug)]
        public static void ChangeContextDemoProd()
        {
            BuildController.SetContext(AppContext.Demo, Environment.Prod);
        }

        #endregion
    }
}