using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.BuildScripts
{
    [CreateAssetMenu(fileName = "BuildScenesCollection", menuName = "BrutalHack/BuildScenesCollection", order = 0)]
    public class BuildScenesCollection : ScriptableObject
    {
        public List<SceneAsset> Scenes;
    }
}