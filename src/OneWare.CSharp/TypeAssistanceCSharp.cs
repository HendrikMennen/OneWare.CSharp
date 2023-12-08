using OneWare.SDK.LanguageService;
using OneWare.SDK.ViewModels;

namespace OneWare.CSharp;

public class TypeAssistanceCSharp : TypeAssistanceLanguageService
{
    public override bool CanAddBreakPoints => true;

    public TypeAssistanceCSharp(IEditor evm, ILanguageService langService) : base(evm, langService)
    {
        LineCommentSequence = "//";
    }

    public override Task<string?> GetHoverInfoAsync(int offset)
    {
        return base.GetHoverInfoAsync(offset);
    }
}