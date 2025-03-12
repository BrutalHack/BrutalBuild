using System;
using System.Diagnostics;
using System.IO;
using System.Timers;
using System.Xml.Serialization;
using BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.Enums;
using UnityEditor;
using UnityEngine;
using UnityEngine.WSA;
using AppContext = BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.Enums.AppContext;
using Debug = UnityEngine.Debug;
using Environment = BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline.Enums.Environment;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline
{
    public class BuildController
    {
        private static string _androidBuildPath = "Build/Android";
        private static string _iOSBuildPath = "Build/iOS";

        /// <summary>
        /// Serializes the config of a given Type to Assets/BuildResources
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static void ExportConfig<T>() where T : new()
        {
            Directory.CreateDirectory("Assets/BuildResources/Exported");
            var xmlFileLocation = $"Assets/BuildResources/Exported/{typeof(T).Name}-{DateTime.Today.ToString("yyyy-mm-dd")}.xml";

            TextWriter writer = new StreamWriter(xmlFileLocation);
            var globalSettingsSerializer = new XmlSerializer(typeof(T));
            globalSettingsSerializer.Serialize(writer, new T());
            Debug.Log(typeof(T).Name + " written to " + xmlFileLocation);
        }
    }
}