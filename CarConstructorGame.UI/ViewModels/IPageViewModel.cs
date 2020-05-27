using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CarConstructorGame.UI.ViewModels
{
    public enum ViewType
    {
        Login,
        Main,
        CarView,
        DetailView
    }
    public interface INavigator
    {

        BaseViewModel CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
      
    }
}
