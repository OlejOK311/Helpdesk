using MediatR;

namespace Application.AppUser.Authorization
{
    public class AuthorizationResponse
    {
        public bool Success { get; set; }
        public string AuthorizationMessage { get; set; }
    }
}