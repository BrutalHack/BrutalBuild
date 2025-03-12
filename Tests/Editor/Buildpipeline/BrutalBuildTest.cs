using System;
using System.IO;
using System.Xml.Serialization;
using BrutalHack.Submodules.BrutalBuild.Scripts.Config.Build;
using NUnit.Framework;
using UnityEngine;

namespace BrutalHack.Submodules.BrutalBuild.Tests.Buildpipeline
{
    public class BrutalBuildTest
    {
        [TestFixture]
        public class BuildConfigSerializationTest
        {
            // TODO Write actual Unit Tests. These here are very messy Integration Tests
            private const string TestXmlPath = "Assets/Submodules/BrutalBuild/Tests/Buildpipeline";

            [Test]
            public void Success_WhenValidValuesInBuildConfig()
            {
                var xmlPath = $"{TestXmlPath}/ValidBuildConfig.xml";
                var streamReader = new StreamReader(xmlPath);
                var buildConfigSerializer = new XmlSerializer(typeof(BuildConfig));
                var buildConfig = (BuildConfig) buildConfigSerializer.Deserialize(streamReader);

                Assert.IsNotNull(buildConfig.PlayerSettings);
                Assert.IsNotNull(buildConfig.UnityCloudSettings);
                Assert.IsNotNull(buildConfig.PlayerSettings.General);
                Assert.IsNotNull(buildConfig.PlayerSettings.Android);
                Assert.IsNotNull(buildConfig.PlayerSettings.Ios);
                Assert.IsTrue(buildConfig.PlayerSettings.General.CompanyName.Equals("mock"));
            }

            [Test]
            public void Success_WhenMissingValuesInBuildConfig()
            {
                var xmlPath = $"{TestXmlPath}/IncompleteBuildConfig.xml";
                var streamReader = new StreamReader(xmlPath);
                var buildConfigSerializer = new XmlSerializer(typeof(BuildConfig));
                var buildConfig = (BuildConfig) buildConfigSerializer.Deserialize(streamReader);

                Assert.IsNotNull(buildConfig.PlayerSettings);
                Assert.IsNotNull(buildConfig.UnityCloudSettings);
                Assert.IsNotNull(buildConfig.PlayerSettings.General);
                Assert.IsNotNull(buildConfig.PlayerSettings.Android);
                Assert.IsNotNull(buildConfig.PlayerSettings.Ios);
                //Will not read from Xml, but take the value from PlayerPrefs
                Assert.IsNotNull(buildConfig.PlayerSettings.General.CompanyName);
            }

            [Test]
            public void Exception_WhenInvalidValuesInBuildConfig()
            {
                // Here we store a config with an invalid schema
                var xmlPath = $"{TestXmlPath}/InvalidBuildConfig.xml";
                var streamReader = new StreamReader(xmlPath);
                var buildConfigSerializer = new XmlSerializer(typeof(BuildConfig));
                Assert.Throws<InvalidOperationException>(() =>
                {
                    var buildConfig = (BuildConfig) buildConfigSerializer.Deserialize(streamReader);
                });
            }
        }
    }
}