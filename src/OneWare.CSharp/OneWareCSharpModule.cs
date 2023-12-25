using System.Runtime.InteropServices;
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
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            var path = Environment.GetEnvironmentVariable("PATH");
            var user = Environment.GetEnvironmentVariable("USER");
            Environment.SetEnvironmentVariable("PATH", $"{path}:/home/{user}/.dotnet/tools");
        }
    }

    public void OnInitialized(IContainerProvider containerProvider)
    {
        //This example adds a context menu for .vhd files
        containerProvider.Resolve<ILanguageManager>().RegisterService(typeof(LanguageServiceCSharp), true, ".cs");
    }
}