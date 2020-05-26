using CarConstructorGame.DAL.Abstract;
using CarConstructorGame.DAL.Implementation.Core;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarConstructorGame.DAL.Implementation.Extensions
{
    public static class DALResolver
    {
        public static void ResoveDAL(this IServiceCollection serviceCollection)
        {
            //serviceCollection.AddDbContext<CsisDbContext>(x =>
            //       x.UseSqlServer(ConfigurationManager.ConnectionStrings["Csis"].ConnectionString))
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddSingleton<IUserRepository, UserRepository>();
            serviceCollection.AddSingleton<ICarRepository, CarRepository>();
          
        }
    }
}
