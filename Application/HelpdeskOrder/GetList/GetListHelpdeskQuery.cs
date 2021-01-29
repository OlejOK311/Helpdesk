using MediatR;

namespace Application.HelpdeskOrder.GetList
{
    public class GetListHelpdeskQuery : IRequest<GetListHelpdeskResponse>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}