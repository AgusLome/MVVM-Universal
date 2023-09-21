using Core.Lib.OS;
using Maui.OS;
using Sysne.Core.OS;
using DependencyService = Sysne.Core.OS.DependencyService;

namespace Maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            //DependencyService.Register<SettingsStorage, ISettingsStorage>();
            DependencyService.Register<SettingsStorage, ISettingsStorage>();
        }
    }
}