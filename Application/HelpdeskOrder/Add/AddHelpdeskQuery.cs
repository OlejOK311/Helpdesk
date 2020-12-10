using MediatR;

namespace Application.HelpdeskOrder.Add
{
    public class AddHelpdeskQuery : IRequest<AddHelpdeskResponse>
    {
        public string number { get; set; }
    }
}