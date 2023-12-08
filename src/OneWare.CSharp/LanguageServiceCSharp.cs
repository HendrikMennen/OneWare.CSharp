using System.Reflection;
using OneWare.SDK.Helpers;
using OneWare.SDK.LanguageService;
using OneWare.SDK.ViewModels;

namespace OneWare.CSharp;

public class LanguageServiceCSharp() : LanguageServiceLsp("OmniSharp", StartPath, "", null)
{
    private static readonly string? StartPath;
    
    static LanguageServiceCSharp()
    {
        var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
            
        StartPath = PlatformHelper.Platform switch
        {
            PlatformId.WinX64 => $"{assemblyPath}/native_tools/win-x64/clangd/OmniSharp.exe",
            PlatformId.LinuxX64 => $"{assemblyPath}/native_tools/linux-x64/clangd/OmniSharp",
            PlatformId.OsxX64 =>$"{assemblyPath}/native_tools/osx-x64/clangd/OmniSharp",
            PlatformId.OsxArm64 => $"{assemblyPath}/native_tools/osx-x64/clangd/OmniSharp",
            _ => null
        };
    }

    public override ITypeAssistance GetTypeAssistance(IEditor editor)
    {
        return new TypeAssistanceCSharp(editor, this);
    }
}