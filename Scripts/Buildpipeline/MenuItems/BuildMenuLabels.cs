namespace BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.MenuItems
{
	public static class BuildMenuLabels
	{
		// Main Menu Entry
		private const string BrutalHack = "BrutalHack/";

		// First Level Navigation
		private const string ChangeContext = BrutalHack + "Change Context/";
		private const string BuildIos = BrutalHack + "Build iOS/";
		private const string BuildAndroid = BrutalHack + "Build Android/";

		private const string General = "General/";
		private const string Demo = "Demo/";
		private const string Dev = "Dev/";
		private const string Prod = "Prod/";
		private const string Debug = "Debug";
		private const string Normal = "Normal";
		private const string Release = "Release";
		private const string Simulator = " (Simulator)";

		/// <summary>
		/// General
		/// </summary>

		#region General Build Ios

		public const string BuildIosGeneralDevDebug =
			BuildIos + General + Dev + Debug;

		public const string BuildIosGeneralDevNormal =
			BuildIos + General + Dev + Normal;

		public const string BuildIosGeneralDevDebugSimulator =
			BuildIos + General + Dev + Debug + Simulator;

		public const string BuildIosGeneralDevNormalSimulator =
			BuildIos + General + Dev + Normal + Simulator;

		public const string BuildIosGeneralProdDebug =
			BuildIos + General + Prod + Debug;

		public const string BuildIosGeneralProdNormal =
			BuildIos + General + Prod + Normal;

		public const string BuildIosGeneralProdDebugSimulator =
			BuildIos + General + Prod + Debug + Simulator;

		public const string BuildIosGeneralProdNormalSimulator =
			BuildIos + General + Prod + Normal + Simulator;

		public const string BuildIosGeneralRelease =
			BuildIos + General + Release;

		#endregion

		#region General Build Android

		public const string BuildAndroidGeneralDevDebug =
			BuildAndroid + General + Dev + Debug;

		public const string BuildAndroidGeneralDevNormal =
			BuildAndroid + General + Dev + Normal;

		public const string BuildAndroidGeneralProdDebug =
			BuildAndroid + General + Prod + Debug;

		public const string BuildAndroidGeneralProdNormal =
			BuildAndroid + General + Prod + Normal;

		public const string BuildAndroidGeneralRelease =
			BuildAndroid + General + Release;

		#endregion

		#region General Change Context

		public const string ChangeContextGeneralDevDebug =
			ChangeContext + General + Dev + Debug;

		public const string ChangeContextGeneralDevNormal =
			ChangeContext + General + Dev + Normal;

		public const string ChangeContextGeneralProdDebug =
			ChangeContext + General + Prod + Debug;

		public const string ChangeContextGeneralProdNormal =
			ChangeContext + General + Prod + Normal;

		#endregion

		/// <summary>
		///  Demo
		/// </summary>

		#region Demo Build Ios

		public const string BuildIosDemoDevDebug =
			BuildIos + Demo + Dev + Debug;

		public const string BuildIosDemoDevNormal =
			BuildIos + Demo + Dev + Normal;

		public const string BuildIosDemoDevDebugSimulator =
			BuildIos + Demo + Dev + Debug + Simulator;

		public const string BuildIosDemoDevNormalSimulator =
			BuildIos + Demo + Dev + Normal + Simulator;

		public const string BuildIosDemoProdDebug =
			BuildIos + Demo + Prod + Debug;

		public const string BuildIosDemoProdNormal =
			BuildIos + Demo + Prod + Normal;

		public const string BuildIosDemoProdDebugSimulator =
			BuildIos + Demo + Prod + Debug + Simulator;

		public const string BuildIosDemoProdNormalSimulator =
			BuildIos + Demo + Prod + Normal + Simulator;

		public const string BuildIosDemoRelease =
			BuildIos + Demo + Release;

		#endregion

		#region Demo Build Android

		public const string BuildAndroidDemoDevDebug =
			BuildAndroid + Demo + Dev + Debug;

		public const string BuildAndroidDemoDevNormal =
			BuildAndroid + Demo + Dev + Normal;

		public const string BuildAndroidDemoProdDebug =
			BuildAndroid + Demo + Prod + Debug;

		public const string BuildAndroidDemoProdNormal =
			BuildAndroid + Demo + Prod + Normal;

		public const string BuildAndroidDemoRelease =
			BuildAndroid + Demo + Release;

		#endregion

		#region Demo Change Context

		public const string ChangeContextDemoDevDebug =
			ChangeContext + Demo + Dev + Debug;

		public const string ChangeContextDemoDevNormal =
			ChangeContext + Demo + Dev + Normal;

		public const string ChangeContextDemoProdDebug =
			ChangeContext + Demo + Prod + Debug;

		public const string ChangeContextDemoProdNormal =
			ChangeContext + Demo + Prod + Normal;

		#endregion
	}
}