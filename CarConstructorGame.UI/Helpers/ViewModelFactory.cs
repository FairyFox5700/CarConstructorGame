using CarConstructorGame.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarConstructorGame.UI.Helpers
{
    public class ViewModelFactory : IViewModelFactory
    {
        private readonly MainViewModel mainViewModel;
        private readonly LoginViewModel loginViewModel;
        private readonly CarDetailViewModel carDetailViewModel;

        public ViewModelFactory(MainViewModel mainViewModel, LoginViewModel loginViewModel,
            CarDetailViewModel carDetailViewModel)
        {
            this.mainViewModel = mainViewModel;
            this.loginViewModel = loginViewModel;
            this.carDetailViewModel = carDetailViewModel;
        }
        public BaseViewModel CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Login:
                    return loginViewModel;
                case ViewType.Main:
                    return mainViewModel;
                case ViewType.DetailView:
                    return carDetailViewModel;
                default:
                    throw new ArgumentException("The View not founded");
            }
        }
    }
}
