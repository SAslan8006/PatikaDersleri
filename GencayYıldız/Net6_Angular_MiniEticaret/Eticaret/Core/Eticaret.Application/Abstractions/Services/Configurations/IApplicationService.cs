using ETicaret.Application.DTOs.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Abstractions.Services.Configurations
{
    public interface IApplicationService
    {
        List<Menu> GetAuthorizeDefinitionEndpoints(Type type);
    }
}
