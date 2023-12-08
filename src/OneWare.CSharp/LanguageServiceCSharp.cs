using System.Reflection;
using OneWare.SDK.Helpers;
using OneWare.SDK.LanguageService;
using OneWare.SDK.ViewModels;

namespace OneWare.CSharp;

public class LanguageServiceCSharp(string workspace) : LanguageServiceLsp("CSharp-LS", StartPath, "", workspace)
{
    private static readonly string? StartPath;
    
    static LanguageServiceCSharp()
    {
        StartPath = PlatformHelper.Platform switch
        {
            _ => $"csharp-ls",
        };
    }

    public override ITypeAssistance GetTypeAssistance(IEditor editor)
    {
        return new TypeAssistanceCSharp(editor, this);
    }
}