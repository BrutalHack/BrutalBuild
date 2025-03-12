using BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.Enums;
using UnityEditor;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.MenuItems
{
	public static class BuildMenuItems
	{
		/// <summary>
		/// General
		/// </summary>

		#region General iOS

		[MenuItem(BuildMenuLabels.BuildIosGeneralDevDebug)]
		public static void BuildIosGeneralDevDebug()
		{
			BuildController.BuildApplication(AppContext.General, Environment.Dev, BuildType.Debug,
				BuildTarget.iOS);
		}

		[MenuItem(BuildMenuLabels.BuildIosGeneralDevDebugSimulator)]
		public static void BuildIosGeneralDevDebugSimulator()
		{
			BuildController.BuildApplication(AppContext.General, Environment.Dev, BuildType.Debug,
				BuildTarget.iOS, iOSSdkVersion.SimulatorSDK);
		}

		[MenuItem(BuildMenuLabels.BuildIosGeneralDevNormal)]
		public static void BuildIosGeneralDevNormal()
		{
			BuildController.BuildApplication(AppContext.General, Environment.Dev, BuildType.Normal,
				BuildTarget.iOS);
		}

		[MenuItem(BuildMenuLabels.BuildIosGeneralDevNormalSimulator)]
		public static void BuildIosGeneralDevNormalSimulator()
		{
			BuildController.BuildApplication(AppContext.General, Environment.Dev, BuildType.Normal,
				BuildTarget.iOS,
				iOSSdkVersion.SimulatorSDK);
		}

		[MenuItem(BuildMenuLabels.BuildIosGeneralProdDebug)]
		public static void BuildIosGeneralProdDebug()
		{
			BuildController.BuildApplication(AppContext.General, Environment.Prod, BuildType.Debug,
				BuildTarget.iOS);
		}

		[MenuItem(BuildMenuLabels.BuildIosGeneralProdDebugSimulator)]
		public static void BuildIosGeneralProdDebugSimulator()
		{
			BuildController.BuildApplication(AppContext.General, Environment.Prod, BuildType.Debug,
				BuildTarget.iOS,
				iOSSdkVersion.SimulatorSDK);
		}

		[MenuItem(BuildMenuLabels.BuildIosGeneralProdNormal)]
		public static void BuildIosGeneralProdNormal()
		{
			BuildController.BuildApplication(AppContext.General, Environment.Prod, BuildType.Normal,
				BuildTarget.iOS);
		}

		[MenuItem(BuildMenuLabels.BuildIosGeneralProdNormalSimulator)]
		public static void BuildIosGeneralProdNormalSimulator()
		{
			BuildController.BuildApplication(AppContext.General, Environment.Prod, BuildType.Normal,
				BuildTarget.iOS,
				iOSSdkVersion.SimulatorSDK);
		}

		[MenuItem(BuildMenuLabels.BuildIosGeneralRelease)]
		public static void BuildIosGeneralRelease()
		{
			BuildController.BuildApplication(AppContext.General, Environment.Prod, BuildType.Normal,
				BuildTarget.iOS, isReleaseBuild: true);
		}

		#endregion

		#region General Android

		[MenuItem(BuildMenuLabels.BuildAndroidGeneralDevDebug)]
		public static void BuildAndroidGeneralDevDebug()
		{
			BuildController.BuildApplication(AppContext.General, Environment.Dev, BuildType.Debug,
				BuildTarget.Android);
		}

		[MenuItem(BuildMenuLabels.BuildAndroidGeneralDevNormal)]
		public static void BuildAndroidGeneralDevNormal()
		{
			BuildController.BuildApplication(AppContext.General, Environment.Dev, BuildType.Normal,
				BuildTarget.Android);
		}

		[MenuItem(BuildMenuLabels.BuildAndroidGeneralProdDebug)]
		public static void BuildAndroidGeneralProdDebug()
		{
			BuildController.BuildApplication(AppContext.General, Environment.Prod, BuildType.Debug,
				BuildTarget.Android);
		}

		[MenuItem(BuildMenuLabels.BuildAndroidGeneralProdNormal)]
		public static void BuildAndroidGeneralProdNormal()
		{
			BuildController.BuildApplication(AppContext.General, Environment.Prod, BuildType.Normal,
				BuildTarget.Android);
		}

		[MenuItem(BuildMenuLabels.BuildAndroidGeneralRelease)]
		public static void BuildAndroidGeneralRelease()
		{
			BuildController.BuildApplication(AppContext.General, Environment.Prod, BuildType.Normal,
				BuildTarget.Android, isReleaseBuild: true);
		}

		#endregion

		/// <summary>
		/// Demo
		/// </summary>

		#region Demo iOS

		[MenuItem(BuildMenuLabels.BuildIosDemoDevDebug)]
		public static void BuildIosDemoDevDebug()
		{
			BuildController.BuildApplication(AppContext.Demo, Environment.Dev, BuildType.Debug,
				BuildTarget.iOS);
		}

		[MenuItem(BuildMenuLabels.BuildIosDemoDevDebugSimulator)]
		public static void BuildIosDemoDevDebugSimulator()
		{
			BuildController.BuildApplication(AppContext.Demo, Environment.Dev, BuildType.Debug,
				BuildTarget.iOS,
				iOSSdkVersion.SimulatorSDK);
		}

		[MenuItem(BuildMenuLabels.BuildIosDemoDevNormal)]
		public static void BuildIosDemoDevNormal()
		{
			BuildController.BuildApplication(AppContext.Demo, Environment.Dev, BuildType.Normal,
				BuildTarget.iOS);
		}

		[MenuItem(BuildMenuLabels.BuildIosDemoDevNormalSimulator)]
		public static void BuildIosDemoDevNormalSimulator()
		{
			BuildController.BuildApplication(AppContext.Demo, Environment.Dev, BuildType.Normal,
				BuildTarget.iOS,
				iOSSdkVersion.SimulatorSDK);
		}

		[MenuItem(BuildMenuLabels.BuildIosDemoProdDebug)]
		public static void BuildIosDemoProdDebug()
		{
			BuildController.BuildApplication(AppContext.Demo, Environment.Prod, BuildType.Debug,
				BuildTarget.iOS);
		}

		[MenuItem(BuildMenuLabels.BuildIosDemoProdDebugSimulator)]
		public static void BuildIosDemoProdDebugSimulator()
		{
			BuildController.BuildApplication(AppContext.Demo, Environment.Prod, BuildType.Debug,
				BuildTarget.iOS,
				iOSSdkVersion.SimulatorSDK);
		}

		[MenuItem(BuildMenuLabels.BuildIosDemoProdNormal)]
		public static void BuildIosDemoProdNormal()
		{
			BuildController.BuildApplication(AppContext.Demo, Environment.Prod, BuildType.Normal,
				BuildTarget.iOS);
		}

		[MenuItem(BuildMenuLabels.BuildIosDemoProdNormalSimulator)]
		public static void BuildIosDemoProdNormalSimulator()
		{
			BuildController.BuildApplication(AppContext.Demo, Environment.Prod, BuildType.Normal,
				BuildTarget.iOS,
				iOSSdkVersion.SimulatorSDK);
		}

		[MenuItem(BuildMenuLabels.BuildIosDemoRelease)]
		public static void BuildIosDemoRelease()
		{
			BuildController.BuildApplication(AppContext.Demo, Environment.Prod, BuildType.Normal,
				BuildTarget.iOS, isReleaseBuild: true);
		}

		#endregion

		#region Demo Android

		[MenuItem(BuildMenuLabels.BuildAndroidDemoDevDebug)]
		public static void BuildAndroidDemoDevDebug()
		{
			BuildController.BuildApplication(AppContext.Demo, Environment.Dev, BuildType.Debug,
				BuildTarget.Android);
		}

		[MenuItem(BuildMenuLabels.BuildAndroidDemoDevNormal)]
		public static void BuildAndroidDemoDevNormal()
		{
			BuildController.BuildApplication(AppContext.Demo, Environment.Dev, BuildType.Normal,
				BuildTarget.Android);
		}

		[MenuItem(BuildMenuLabels.BuildAndroidDemoProdDebug)]
		public static void BuildAndroidDemoProdDebug()
		{
			BuildController.BuildApplication(AppContext.Demo, Environment.Prod, BuildType.Debug,
				BuildTarget.Android);
		}

		[MenuItem(BuildMenuLabels.BuildAndroidDemoProdNormal)]
		public static void BuildAndroidDemoProdNormal()
		{
			BuildController.BuildApplication(AppContext.Demo, Environment.Prod, BuildType.Normal,
				BuildTarget.Android);
		}

		[MenuItem(BuildMenuLabels.BuildAndroidDemoRelease)]
		public static void BuildAndroidDemoRelease()
		{
			BuildController.BuildApplication(AppContext.Demo, Environment.Prod, BuildType.Normal,
				BuildTarget.Android, isReleaseBuild: true);
		}

		#endregion
		
	}
}