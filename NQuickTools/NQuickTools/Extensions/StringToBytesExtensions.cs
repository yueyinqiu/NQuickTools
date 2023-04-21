using System.Diagnostics.CodeAnalysis;

namespace NQuickTools.Extensions
{
    public static class StringToBytesExtensions
    {
        public static bool Base64TryToBytes(this string base64, out byte[] result)
        {
            // https://stackoverflow.com/a/51301284/15283686

            result = new byte[(base64.Length * 3 + 3) / 4 -
                (base64.Length > 0 && base64[^1] == '=' ?
                    base64.Length > 1 && base64[^2] == '=' ? 2 : 1 : 0)];
            return Convert.TryFromBase64String(base64, result, out _);
        }
    }
}
