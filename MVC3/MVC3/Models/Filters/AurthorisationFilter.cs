using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC3.Models.Filters
{
    public class AurthorisationFilter : AuthorizeAttribute
    {
        
            public override void OnAuthorization(AuthorizationContext filterContext)
            {
                Debug.WriteLine("OnAuthorization : AuthorizationFilterA");
            }
        }
        public class FilterB : AuthorizeAttribute
        {
            public override void OnAuthorization(AuthorizationContext filterContext)
            {
                Debug.WriteLine("OnAuthorization : AuthorizationFilterB");
            }
        }
    }
