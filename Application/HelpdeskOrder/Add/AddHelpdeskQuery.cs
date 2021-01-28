using MediatR;

namespace Application.HelpdeskOrder.Add
{
    public class AddHelpdeskQuery : IRequest<Unit>
    {
        public string Number { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}