using CarConstructorGame.DAL.Implementation.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace CarConstructorGame.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; set; }
        private void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.ResoveDAL();
        }
    }
}
