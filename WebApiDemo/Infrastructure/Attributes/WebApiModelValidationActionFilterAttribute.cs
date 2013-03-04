using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebApiDemo.Infrastructure.Attributes
{
    public class WebApiModelValidationActionFilterAttribute :ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (!actionContext.ModelState.IsValid)
            {
                var errors = actionContext.ModelState
                    .Where(e => e.Value.Errors.Count > 0)
                    .Select(e => new Error
                    {
                        Name = e.Key,
                        //TODO: The message needs to show all errors
                        Message = e.Value.Errors.Select(x=>x.ErrorMessage).ToArray()
                    });

                actionContext.Response = actionContext.Request.CreateResponse<Error[]>(HttpStatusCode.BadRequest,errors.ToArray());
            }
        }
    }
}