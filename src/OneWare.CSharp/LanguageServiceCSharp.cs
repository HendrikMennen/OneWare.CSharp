using System.Reflection;
using OneWare.SDK.Helpers;
using OneWare.SDK.LanguageService;
using OneWare.SDK.ViewModels;

namespace OneWare.CSharp;

public class LanguageServiceCSharp(string workspace) : LanguageServiceLsp("CSharp-LS", StartPath, string.Empty, workspace)
{
    private static readonly string? StartPath;
    
    static LanguageServiceCSharp()
    {
        StartPath = PlatformHelper.Platform switch
        {
            PlatformId.WinX64 => $"csharp-ls.exe",
            _ => $"csharp-ls",
        };
    }

    public override ITypeAssistance GetTypeAssistance(IEditor editor)
    {
        return new TypeAssistanceCSharp(editor, this);
    }
}