﻿using WebApplication1.Contracts;
using WebApplication1.Repository;

namespace WebApplication1.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader());
            });
        }
        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();


        public static void AddFluentEmails(this IServiceCollection services)
        {
            var defaulEmail = "kk@gmail.com";
            var host = "localhost";
            var port=25;
            
            services.AddFluentEmail(defaulEmail).AddSmtpSender(host, port);

        }
    }
}
