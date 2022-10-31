using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Features.Queries.Role.GetRoles
{
    public class GetRolesQueryRequest : IRequest<GetRolesQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}
