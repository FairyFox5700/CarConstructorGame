using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CarConstructorGame.UI.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private IPageViewModel currentPageViewModel;
        public IPageViewModel CurrentPageViewModel
        {
            get => currentPageViewModel;
            set
            {
                if (currentPageViewModel != value)
                {
                    currentPageViewModel = value;
                    OnPropertyChanged(nameof(CurrentPageViewModel));
                }

            }
        }
    }
}
