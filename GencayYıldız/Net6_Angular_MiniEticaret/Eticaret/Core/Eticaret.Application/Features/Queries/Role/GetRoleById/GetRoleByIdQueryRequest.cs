using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Features.Queries.Role.GetRoleById
{
    public class GetRoleByIdQueryRequest : IRequest<GetRoleByIdQueryResponse>
    {
        public string Id { get; set; }
    }
}
