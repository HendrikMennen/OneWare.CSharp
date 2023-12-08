using OneWare.SDK.Models;
using OneWare.SDK.Services;
using OneWare.SDK.ViewModels;
using Prism.Ioc;
using Prism.Modularity;

namespace OneWare.CSharp;

public class OneWareCSharpModule : IModule
{
    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
    }

    public void OnInitialized(IContainerProvider containerProvider)
    {
        //This example adds a context menu for .vhd files
        containerProvider.Resolve<ILanguageManager>().RegisterService(typeof(LanguageServiceCSharp), true, ".cs");
    }
}