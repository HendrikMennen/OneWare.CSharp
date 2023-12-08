using OneWare.SDK.LanguageService;
using OneWare.SDK.ViewModels;

namespace OneWare.CSharp;

public class TypeAssistanceCSharp : TypeAssistanceLanguageService
{
    public TypeAssistanceCSharp(IEditor evm, ILanguageService langService) : base(evm, langService)
    {
    }
}