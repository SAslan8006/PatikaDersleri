using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    public static class ServiceTool
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceCollection Create(IServiceCollection serviceColletion)
        {
            serviceColletion.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            ServiceProvider = serviceColletion.BuildServiceProvider();
            return serviceColletion;
        }

    }
}
