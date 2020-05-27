using CarConstructorGame.BLL.Abstract;
using CarConstructorGame.UI.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CarConstructorGame.UI.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        private ILoginService loginService;
        public INavigator Navigator { get; set; }
        
        public MainViewModel(INavigator navigator, ILoginService loginService)
        {
            Navigator = navigator;
            this.loginService = loginService;
            Navigator.UpdateCurrentViewModelCommand.Execute(ViewType.CarView);
        }

        private ICommand goToLoginView;
        public ICommand GoToLoginView
        {
            get
            {
                if (goToLoginView == null)
                    goToLoginView = new RelayCommand(action => CurrentPageViewModel = new LoginViewModel();
                return goToLoginView;
            }
        }

        private ICommand goToCarDetailView;
        public ICommand GoToCarDetailView
        {
            get
            {
                if (goToCarDetailView == null)
                    goToCarDetailView = new RelayCommand(action => CurrentPageViewModel = new CarDetailViewModel());
                return goToCarDetailView;
            }
        }

      
    }
}
