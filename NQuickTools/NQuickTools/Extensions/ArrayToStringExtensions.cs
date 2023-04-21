namespace NQuickTools.Extensions
{
    public static class ArrayToStringExtensions
    {
        public static string ArrayToString<T>(this IEnumerable<T> array)
        {
            var s = string.Join(", ", array);
            return $"[{s}]";
        }
        public static string ToBase64(this byte[] array)
        {
            return Convert.ToBase64String(array);
        }
        public static string ToHex(this byte[] array)
        {
            return Convert.ToHexString(array);
        }
    }
}
