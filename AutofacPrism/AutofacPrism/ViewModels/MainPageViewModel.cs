using Prism.Mvvm;
using Prism.Navigation;

namespace AutofacPrism.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string title;

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                base.SetProperty(ref this.title, value);
            }
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }
    }
}
