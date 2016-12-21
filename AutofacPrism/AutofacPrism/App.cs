using AutofacPrism.ViewModels;
using AutofacPrism.Views;
using Prism.Autofac;
using Prism.Autofac.Forms;

namespace AutofacPrism
{
    public class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer)
        {
        }

        protected override void OnInitialized()
        {
            base.NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes()
        {
            base.Container.RegisterTypeForNavigation<MainPage, MainPageViewModel>("MainPage");
        }
    }
}
