using Prism.Mvvm;
using Prism.Navigation;

namespace ProjectHandbook.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware, IDestructible
    {
        public ViewModelBase(INavigationService navigationService)
        {
            this.NavigationService = navigationService;
        }

        protected INavigationService NavigationService { get; private set; }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatingTo(INavigationParameters parameters)
        {
        }

        public virtual void Destroy()
        {
        }
    }
}
