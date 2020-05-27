using CarConstructorGame.BLL.Abstract;
using CarConstructorGame.UI.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CarConstructorGame.UI.ViewModels
{
    public class MainViewModel:BaseViewModel, IPageViewModel
    {
        private ILoginService loginService;
        public MainViewModel(ILoginService loginService)
        {
            this.loginService = loginService;
        }
        public MainViewModel()
        {

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
