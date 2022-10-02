using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Features.Queries.Order
{
    public class GetAllOrdersQueryResponse
    {
        public int TotalOrderCount { get; set; }
        public object Orders { get; set; }
    }
}
