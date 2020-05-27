using CarConstructorGame.UI.Commands;
using CarConstructorGame.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace CarConstructorGame.UI.ViewModels
{
    public class Navigator : BaseViewModel, INavigator
    {
        private BaseViewModel currentViewModel;
        public BaseViewModel CurrentViewModel
        {
            get
            {
                return currentViewModel;
            }
            set
            {
                currentViewModel = value;
               OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public ICommand UpdateCurrentViewModelCommand { get; set; }

        public Navigator(IViewModelFactory viewModelFactory)
        {
            UpdateCurrentViewModelCommand = new UpdateCurrentViewModelCommand(this, viewModelFactory);
        }
    }
}
