using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.HelpdeskOrder.Delete
{
    public class DeleteHelpdeskQuery : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
