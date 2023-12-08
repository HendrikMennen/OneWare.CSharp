using AvaloniaEdit.Folding;
using AvaloniaEdit.Indentation.CSharp;
using OneWare.CSharp.Folding;
using OneWare.SDK.EditorExtensions;
using OneWare.SDK.LanguageService;
using OneWare.SDK.ViewModels;

namespace OneWare.CSharp;

public class TypeAssistanceCSharp : TypeAssistanceLanguageService
{
    public override bool CanAddBreakPoints => true;

    public TypeAssistanceCSharp(IEditor evm, LanguageServiceCSharp langService) : base(evm, langService)
    {
        LineCommentSequence = "//";
        CodeBox.TextArea.IndentationStrategy = IndentationStrategy = new CSharpIndentationStrategy(CodeBox.Options);
        FoldingStrategy = new RegexFoldingStrategy(FoldingRegexCSharp.FoldingStart, FoldingRegexCSharp.FoldingEnd);
    }

    public override Task<string?> GetHoverInfoAsync(int offset)
    {
        return base.GetHoverInfoAsync(offset);
    }
}