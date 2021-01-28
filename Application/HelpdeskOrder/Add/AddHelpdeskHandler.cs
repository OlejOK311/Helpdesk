using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using EFData;

namespace Application.HelpdeskOrder.Add
{
    public class AddHelpdeskHandler : IRequestHandler<AddHelpdeskQuery>
    {
        private readonly DataContext _context;

        public AddHelpdeskHandler(DataContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(AddHelpdeskQuery request, CancellationToken cancellationToken)
        {
            var helpdeskOrder = new Domain.HelpdeskOrder
            {
                Number = request.Number,
                Title = request.Title,
                Description = request.Description
            };

            _context.HelpdeskOrders.Add(helpdeskOrder);
            _context.SaveChanges();

            return await Unit.Task;
        }
    }
}
