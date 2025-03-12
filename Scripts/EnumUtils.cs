using System;

namespace BrutalHack.Submodules.BrutalBuild.Scripts.Config
{
    public static class EnumUtils
    {
        public static T ParseEnum<T>(string value) where T : struct, IConvertible
        {
            if (typeof(T).IsEnum)
            {
                return (T) Enum.Parse(typeof(T), value);
            }

            throw new InvalidOperationException($"Cannot parse string {value} to non-enum type {typeof(T).FullName}");
        }
    }
}