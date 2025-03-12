using Sirenix.OdinInspector;
using UnityEditor;
using UnityEngine;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.BuildScripts
{
    [CreateAssetMenu(fileName = "BrutalPlatformConfig", menuName = "BrutalHack/BrutalPlatformConfig", order = 0)]
    public class BuildPlatformConfig : ScriptableObject
    {
        public BuildTargetGroup BuildTargetGroup;
        public BuildTarget BuildTarget;

        [Title("Android, ChromeOS")]
        public bool BuildAppBundle;

        public bool ExportAsGoogleAndroidProject;

        [Title("macOS, iOS, tvOS")]
        public bool CreateXcodeProject;
    }
}