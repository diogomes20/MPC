﻿namespace Mpc.WinFormsIoC.Presentation.Config
{
    using System.Configuration;
    using System.Windows.Forms;
    using Microsoft.Extensions.DependencyInjection;
    using Mpc.WinFormsIoC.Application.Services.Configuration;
    using Mpc.WinFormsIoC.Data.Ef.Configuration;
    using Mpc.WinFormsIoC.Infrastructure.CrossCutting.Settings;

    public static class IoC
    {
        private static ServiceProvider ServiceProvider = null;

        public static T GetForm<T>() where T : Form
        {
            return ServiceProvider.GetRequiredService<T>();
        }

        public static void Init()
        {
            var services = new ServiceCollection();
            RegisterForms(services);

            var appSettings = new AppSettings
            {
                DataBaseSettings = new DataBaseSettings
                {
                    ConnectionString = ConfigurationManager.AppSettings["DataBaseConnectionString"]
                }
            };

            services.ConfigureApplicationServices(appSettings);
            services.ConfigureDataEf(appSettings);

            ServiceProvider = services.BuildServiceProvider();
        }

        private static void RegisterForms(IServiceCollection services)
        {
            services.AddSingleton<FrmMain>();
            services.AddSingleton<Core.FrmLoading>();
            services.AddTransient<Countries.FrmCountryList>();
            services.AddTransient<Countries.FrmCountriesEdit>();
            services.AddTransient<Users.FrmLogin>();
            services.AddTransient<Users.FrmUserEdit>();
            services.AddTransient<Users.FrmUserList>();
            services.AddTransient<Place.FrmPlaceList>();
            services.AddTransient<Place.FrmPlaceEdit>();
            services.AddTransient<Review.FrmReviewEdit>();
            services.AddTransient<Review.FrmReviewList>();
        }
    }
}
