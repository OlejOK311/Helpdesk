using EFData;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.HelpdeskOrder.Delete
{
    class DeleteHelpdeskHandler : IRequestHandler<DeleteHelpdeskQuery>
    {
        private readonly DataContext _context;

        public DeleteHelpdeskHandler(DataContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteHelpdeskQuery request, CancellationToken cancellationToken)
        {
            _context.HelpdeskOrders.Remove(await _context.HelpdeskOrders.FirstOrDefaultAsync(p => p.Id == request.Id));
            _context.SaveChanges();

            return await Unit.Task;
        }
    }
}
