using EFData;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.HelpdeskOrder.Get
{
    class GetListHelpdeskHandler : IRequestHandler<GetListHelpdeskQuery, GetListHelpdeskResponse>
    {
        private readonly DataContext _context;

        public GetListHelpdeskHandler(DataContext context)
        {
            _context = context;
        }
        public async Task<GetListHelpdeskResponse> Handle(GetListHelpdeskQuery request, CancellationToken cancellationToken)
        {
            var helpdesks = _context.HelpdeskOrders;

            var p = helpdesks.Skip((request.Page - 1) * request.PageSize).Take(request.PageSize);

            return new GetListHelpdeskResponse()
            {
                Helpdesk = p.ToList()
            };
        }
    }
}