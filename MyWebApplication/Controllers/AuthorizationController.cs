using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.AppUser.Authorization;
using Application.HelpdeskOrder.Add;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApplication.Controllers
{
    [AllowAnonymous]
    public class AuthorizationController : BaseController
    {
        [HttpPost("authorization")]
        public async Task<ActionResult<AuthorizationResponse>> AuthorizationAsync(AuthorizationQuery query)
        {
            return await Mediator.Send(query);
        }
    }
}
