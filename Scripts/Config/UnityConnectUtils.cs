using System;
using BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build;
using UnityEngine;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config
{
    public class UnityConnectUtils
    {
        /// <summary>
        /// Sets the Unity Connect (Cloud Project) ID via brutal reflection
        /// Source: https://github.com/DragonBox/gists/blob/master/Assets/UnityUtils/Editor/UnityConnectUtils.cs
        /// License: MIT
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="company"></param>
        public static void SetCloudProjectId(string id, string name, string company)
        {
            var type = Type.GetType(
                "UnityEditor.Connect.UnityConnect, UnityEditor, Version = 0.0.0.0, Culture = neutral, PublicKeyToken = null");
            var instanceInfo = type.GetProperty("instance");
            var settingsInstance = instanceInfo.GetValue(null, null);
            var unbind = type.GetMethod("UnbindProject");
            var bind = type.GetMethod("BindProject");

            Debug.Log("Unbinding current cloud project");
            unbind.Invoke(settingsInstance, new object[] { });

            Debug.LogFormat("Binding cloud project to {0}: {1} ({2})", name, id, company);
            bind.Invoke(settingsInstance, new object[] {id, name, company});
        }

        public static void SetCloudProjectId(XmlUnityCloudSettings cloudSettings)
        {
            SetCloudProjectId(cloudSettings.Id, cloudSettings.Product, cloudSettings.Company);
        }
    }
}