using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.HelpdeskOrder.Add;
using Application.HelpdeskOrder.Get;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApplication.Controllers
{
    [AllowAnonymous]
    public class HelpdeskController : BaseController
    {
        [HttpPost("addhelpdesk")]
        public async Task<ActionResult<AddHelpdeskResponse>> AddHelpdeskAsync(AddHelpdeskQuery query)
        {
            return await Mediator.Send(query);
        }

        [HttpPost("getlisthelpdesk")]
        public async Task<ActionResult<GetListHelpdeskResponse>> GetListHelpdeskAsync(GetListHelpdeskQuery query)
        {
            return await Mediator.Send(query);
        }
    }
}
