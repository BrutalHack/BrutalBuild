namespace BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.MenuItems
{
    public static class BuildMenuLabels
    {
        // Main Menu Entry
        private const string BrutalHack = "BrutalHack/";

        // First Level Navigation
        private const string ChangeContext = BrutalHack + "Change Context/";

        private const string Release = "Release/";
        private const string Demo = "Demo/";
        private const string Dev = "Dev";
        private const string Prod = "Prod";


        public const string ChangeContextGeneralDevDebug =
            ChangeContext + Release + Dev;

        public const string ChangeContextGeneralProdDebug =
            ChangeContext + Release + Prod;


        public const string ChangeContextDemoDevDebug =
            ChangeContext + Demo + Dev;

        public const string ChangeContextDemoProdDebug =
            ChangeContext + Demo + Prod;
    }
}