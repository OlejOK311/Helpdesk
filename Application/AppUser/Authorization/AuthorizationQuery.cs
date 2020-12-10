using MediatR;

namespace Application.AppUser.Authorization
{
    public class AuthorizationQuery : IRequest<AuthorizationResponse>
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}