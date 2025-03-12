using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;


namespace BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.BuildScripts
{
    [CreateAssetMenu(fileName = "BrutalEditionConfig", menuName = "BrutalHack/BrutalEditionConfig", order = 0)]
    public class BuildEditionConfig : ScriptableObject
    {
        public string Name;
        public List<BuildScenesCollection> Scenes;
        
        public string[] GetAllScenePaths()
        {
            var scenes = new List<SceneAsset>();
            foreach (var buildScenesCollection in Scenes)
            {
                scenes.AddRange(buildScenesCollection.Scenes);
            }

            return scenes.Select(AssetDatabase.GetAssetPath).ToArray();
        } 
    }
}