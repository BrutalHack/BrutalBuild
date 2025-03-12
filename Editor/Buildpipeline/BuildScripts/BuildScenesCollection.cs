using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Editor.BuildScripts
{
    [CreateAssetMenu(fileName = "BuildScenesCollection", menuName = "BrutalHack/BuildScenesCollection", order = 0)]
    public class BuildScenesCollection : ScriptableObject
    {
        public List<SceneAsset> Scenes;
    }
}