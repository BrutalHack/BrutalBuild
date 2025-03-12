using System.Collections.Generic;
using UnityEngine;

namespace Editor.BuildScripts
{
    [CreateAssetMenu(fileName = "BrutalEditionConfig", menuName = "BrutalHack/BrutalEditionConfig", order = 0)]
    public class BuildEditionConfig : ScriptableObject
    {
        public string Name;
        public List<BuildScenesCollection> Scenes;
    }
}