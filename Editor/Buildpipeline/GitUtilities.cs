using System;
using System.IO;
using System.Text.RegularExpressions;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Buildpipeline
{
    public class GitUtilities
    {
        private const string couldNotParseGitRefMessage = "Are you on a properly named release branch?\n" +
                                                          "Could not parse the following gitRef string: ";
        /// <summary>
        /// Reads the current release branch version from git.
        /// Only works with the format "release-X.Y.Z", where X, Y, and Z can have a length or 1+
        /// </summary>
        /// <returns></returns>
        public static string GetReleaseVersionIfOnGitBranch()
        {
            string gitRef = File.ReadAllText(@".git/HEAD");
            return GetReleaseVersionFromGitRefString(gitRef);
        }

        private static string GetReleaseVersionFromGitRefString(string gitRef)
        {
            try
            {
                string pattern = @"ref:.*\/release-(\d+\.\d+\.\d+)";
                string version = Regex.Match(gitRef, pattern).Groups[1].Value;

                if (string.IsNullOrWhiteSpace(version))
                {
                    throw new InvalidOperationException();
                }

                return version;
            }
            catch (Exception)
            {
                throw new InvalidOperationException(couldNotParseGitRefMessage + gitRef);
            }
        }

        [Obsolete("This method is intended for testing purposes and internal use only.")]
        public static string GetReleaseVersionFromGitRef(string gitRef)
        {
            return GetReleaseVersionFromGitRefString(gitRef);
        }
    }
}