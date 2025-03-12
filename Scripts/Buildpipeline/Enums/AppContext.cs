using System;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.Enums
{
    public enum AppContext
    {
        [Obsolete("Testing only")]
        Mock,
        [Obsolete("Used internally")]
        General,
        Demo
    }
}