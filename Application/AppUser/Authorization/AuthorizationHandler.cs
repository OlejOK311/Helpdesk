using EFData;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.AppUser.Authorization
{
    class AuthorizationHandler : IRequestHandler<AuthorizationQuery, AuthorizationResponse>
    {
        private readonly DataContext _context;
        private readonly UserManager<Domain.AppUser> _userManager;

        public AuthorizationHandler(DataContext context, UserManager<Domain.AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<AuthorizationResponse> Handle(AuthorizationQuery request, CancellationToken cancellationToken)
        {
            var getUser = await _userManager.FindByNameAsync(request.Login);

            return new AuthorizationResponse()
            {
                Success = true,
                AuthorizationMessage = $"Пользователь {getUser.Email} найден."
            };
        }
    }
}
