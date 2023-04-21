using NQuickTools.ToolComponents;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;

namespace NQuickTools.Services.Tools
{
    public sealed class ToolsProvider
    {
        private static readonly ToolInformation[] toolArray = new ToolInformation[] {
            new (Guid.Parse("aa3b39a8-1361-4ad5-9784-9a31dfbc80b6"),
                "Guid Generator",
                "Generate GUIDs.",
                typeof(GuidGenerator)),
            new (Guid.Parse("5c699749-dc52-43e2-ab3a-0200fec7fdd1"),
                "Base64 - Bytes Converter",
                "Convert between base64 strings and byte arrays (or files).",
                typeof(Base64BytesConverter)),
        };

        private static readonly Dictionary<Guid, ToolInformation> toolDictionary;

        static ToolsProvider()
        {
            toolArray = toolArray
                .OrderBy(tool => tool.Name)
                .ThenBy(tool => tool.Id)
                .ToArray();

            toolDictionary = toolArray.ToDictionary(tool => tool.Id);
        }

        public IEnumerable<ToolInformation> EnumerateTools()
        {
            return toolArray;
        }

        public bool TryGetTool(Guid guid, [MaybeNullWhen(false)] out ToolInformation tool)
        {
            return toolDictionary.TryGetValue(guid, out tool);
        }
    }
}
