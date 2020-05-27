using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CarConstructorGame.UI.ViewModels
{
    public class ViewModelLocator
    {
        private readonly IContainer container;
        public ViewModelLocator(IServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
            services.AddSingleton<MainWindow>();
         
        }
    }
}
