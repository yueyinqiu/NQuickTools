using System.Diagnostics.CodeAnalysis;

namespace NQuickTools.Extensions
{
    public static class StreamExtensions
    {
        public static async ValueTask<byte[]> ToArrayAsync(this Stream stream)
        {
            using var memory = new MemoryStream();
            await stream.CopyToAsync(memory);
            return memory.ToArray();
        }
    }
}
