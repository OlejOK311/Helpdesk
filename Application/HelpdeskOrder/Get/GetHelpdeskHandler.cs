using EFData;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.HelpdeskOrder.Get
{
    public class GetHelpdeskHandler : IRequestHandler<GetHelpdeskQuery, GetHelpdeskResponse>
    {
        private readonly DataContext _context;

        public GetHelpdeskHandler(DataContext context)
        {
            _context = context;
        }

        public async Task<GetHelpdeskResponse> Handle(GetHelpdeskQuery request, CancellationToken cancellationToken)
        {
            var getHelpdeskResponse = await _context.HelpdeskOrders.FirstOrDefaultAsync(p => p.Number == request.Number);

            return new GetHelpdeskResponse()
            {
                Number = getHelpdeskResponse.Number,
                Title = getHelpdeskResponse.Title,
                Description = getHelpdeskResponse.Description
            };
        }
    }
}
