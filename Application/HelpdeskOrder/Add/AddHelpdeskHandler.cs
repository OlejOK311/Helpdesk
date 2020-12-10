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
    public class AddHelpdeskHandler : IRequestHandler<AddHelpdeskQuery, AddHelpdeskResponse>
    {
        private readonly DataContext _context;

        public AddHelpdeskHandler(DataContext context)
        {
            _context = context;
        }
        public Task<AddHelpdeskResponse> Handle(AddHelpdeskQuery request, CancellationToken cancellationToken)
        {
            var helpdeskOrder = new Domain.HelpdeskOrder
            {
                Number = request.number,
                Title = "abc",
                Description = "abc"
            };

            _context.HelpdeskOrders.Add(helpdeskOrder);
            _context.SaveChanges();
            return null;
        }
    }
}
