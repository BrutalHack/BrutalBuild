namespace BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.MenuItems
{
    public static class BuildMenuLabels
    {
        // Main Menu Entry
        private const string BrutalHack = "BrutalHack/";

        // First Level Navigation
        private const string ChangeContext = BrutalHack + "Change Context/";

        private const string Release = "Release/";
        private const string ReleaseSteam = "ReleaseSteam/";
        private const string Dev = "Dev";
        private const string Prod = "Prod";


        public const string ChangeContextReleaseDevDebug =
            ChangeContext + Release + Dev;

        public const string ChangeContextReleaseProdDebug =
            ChangeContext + Release + Prod;
        
        public const string ChangeContextReleaseSteamDevDebug =
            ChangeContext + ReleaseSteam + Dev;

        public const string ChangeContextReleaseSteamProdDebug =
            ChangeContext + ReleaseSteam + Prod;
    }
}