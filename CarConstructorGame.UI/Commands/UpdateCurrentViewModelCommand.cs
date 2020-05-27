using CarConstructorGame.UI.Helpers;
using CarConstructorGame.UI.ViewModels;
using System;
using System.Windows.Input;

namespace CarConstructorGame.UI.Commands
{

    public class UpdateCurrentViewModelCommand : ICommand
    {
        private INavigator navigator { get; set; }
        public event EventHandler CanExecuteChanged;

        private readonly IViewModelFactory viewModelFactory;
        public UpdateCurrentViewModelCommand(INavigator navigator, IViewModelFactory viewModelFactory)
        {
            this.navigator = navigator;
            this.viewModelFactory = viewModelFactory;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;

                navigator.CurrentViewModel = viewModelFactory.CreateViewModel(viewType);
            }
        }
    }
}
