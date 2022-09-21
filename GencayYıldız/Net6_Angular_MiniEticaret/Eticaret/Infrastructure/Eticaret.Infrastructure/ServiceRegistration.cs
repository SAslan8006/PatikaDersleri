using ETicaret.Application.Repositories;
using ETicaret.Application.Services;
using ETicaret.Infrastructure.Services.ETicaretAPI.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructreServices(this IServiceCollection serviceColletion)
        {
            serviceColletion.AddScoped<IFileService,FileService>();            

        }

    }
}
