using System.Collections.Generic;

namespace NQuickTools.Services.Tools
{
    public record ToolInformation(
        Guid Id, string Name, string Description, Type ComponentType);
}
