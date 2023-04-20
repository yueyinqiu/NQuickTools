using System;

namespace NQuickTools.Extensions
{
    public static class ArrayToStringExtensions
    {
        public static string ArrayToString<T>(this IEnumerable<T> array)
        {
            return $"[{string.Join(", ", array)}]";
        }

        public static string ToBase64String(this byte[] array)
        {
            return Convert.ToBase64String(array);
        }
        public static string ToHexString(this byte[] array)
        {
            return Convert.ToHexString(array);
        }
    }
}
