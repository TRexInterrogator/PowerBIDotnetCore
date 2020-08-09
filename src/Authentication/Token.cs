

using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace src.Authentication {

    public class Token : Attribute, IAuthorizationFilter {

        public static string BearerToken = "Bearer password";


        public void OnAuthorization(AuthorizationFilterContext context) {
            if (context != null) {

                var authtoken = context.HttpContext.Request.Headers["Authorization"].ToString();
                if (BearerToken != authtoken) context.Result = new JsonResult("Bearer Token invalid") { StatusCode = StatusCodes.Status401Unauthorized };
            }
        }   
    }
}