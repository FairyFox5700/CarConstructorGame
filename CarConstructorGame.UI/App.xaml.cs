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
        private readonly IServiceProvider serviceProvider;

        public App()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            serviceProvider = serviceCollection.BuildServiceProvider();
        }
        private void ConfigureServices(IServiceCollection serviceCollection)
        {
           
            serviceCollection.ResoveDAL();
            //serviceCollection.AddTransient<>
        }
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
