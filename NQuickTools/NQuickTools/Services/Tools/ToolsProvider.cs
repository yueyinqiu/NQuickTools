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
