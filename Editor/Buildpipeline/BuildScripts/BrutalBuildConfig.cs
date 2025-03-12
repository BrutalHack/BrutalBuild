using System;
using System.Text.RegularExpressions;
using UnityEngine;
using AppContext = BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.Enums.AppContext;
using UnityEngine.Serialization;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.BuildScripts
{
    [CreateAssetMenu(fileName = "BrutalBuildConfig", menuName = "BrutalHack/BrutalBuildConfig", order = 0)]
    public class BrutalBuildConfig : ScriptableObject
    {
        private string _version;
        public AppContext AppContext;
        public BuildEditionConfig BuildEditionConfig;
        public BuildPlatformConfig BuildPlatformConfig;
        [FormerlySerializedAs("IsDebug")]
        public bool IsDebugMode;


        public string Version
        {
            get => _version;
            set
            {
                var semanticVersionRegex = new Regex(@"^(\d+)\.(\d+)\.(\d+)$");
                if (semanticVersionRegex.IsMatch(value))
                    _version = value;
                else
                    throw new InvalidOperationException("Invalid version " + value + "is not a valid semantic version");
            }
        }
    }
}