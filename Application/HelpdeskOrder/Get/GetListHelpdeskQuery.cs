using MediatR;

namespace Application.HelpdeskOrder.Get
{
    public class GetListHelpdeskQuery : IRequest<GetListHelpdeskResponse>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}