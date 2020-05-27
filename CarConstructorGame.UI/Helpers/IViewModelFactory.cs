using CarConstructorGame.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarConstructorGame.UI.Helpers
{
    public interface IViewModelFactory
    {
        BaseViewModel CreateViewModel(ViewType viewType);
        
    }
}
