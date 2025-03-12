using BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.Enums;
using UnityEditor;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.MenuItems
{
	public static class ChangeContextMenuItems
	{
		#region General

		[MenuItem(BuildMenuLabels.ChangeContextGeneralDevDebug)]
		public static void ChangeContextGeneralDevDebug()
		{
			BuildController.SetContext(AppContext.General, Environment.Dev, BuildType.Debug);
		}

		[MenuItem(BuildMenuLabels.ChangeContextGeneralDevNormal)]
		public static void ChangeContextgeneralDevNormal()
		{
			BuildController.SetContext(AppContext.General, Environment.Dev, BuildType.Normal);
		}

		[MenuItem(BuildMenuLabels.ChangeContextGeneralProdDebug)]
		public static void ChangeContextGeneralProdDebug()
		{
			BuildController.SetContext(AppContext.General, Environment.Prod, BuildType.Debug);
		}

		[MenuItem(BuildMenuLabels.ChangeContextGeneralProdNormal)]
		public static void ChangeContextGeneralProdNormal()
		{
			BuildController.SetContext(AppContext.General, Environment.Prod, BuildType.Normal);
		}

		#endregion

		#region Demo

		[MenuItem(BuildMenuLabels.ChangeContextDemoDevDebug)]
		public static void ChangeContextDemoDevDebug()
		{
			BuildController.SetContext(AppContext.Demo, Environment.Dev, BuildType.Debug);
		}

		[MenuItem(BuildMenuLabels.ChangeContextDemoDevNormal)]
		public static void ChangeContextDemoDevNormal()
		{
			BuildController.SetContext(AppContext.Demo, Environment.Dev, BuildType.Normal);
		}


		[MenuItem(BuildMenuLabels.ChangeContextDemoProdDebug)]
		public static void ChangeContextDemoProdDebug()
		{
			BuildController.SetContext(AppContext.Demo, Environment.Prod, BuildType.Debug);
		}

		[MenuItem(BuildMenuLabels.ChangeContextDemoProdNormal)]
		public static void ChangeContextDemoProdNormal()
		{
			BuildController.SetContext(AppContext.Demo, Environment.Prod, BuildType.Normal);
		}

		#endregion

	}
}