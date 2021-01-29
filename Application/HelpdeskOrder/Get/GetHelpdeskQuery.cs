using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.HelpdeskOrder.Get
{
    public class GetHelpdeskQuery : IRequest<GetHelpdeskResponse> 
    {
        public string Number { get; set; }
    }
}
