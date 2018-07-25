﻿using System.Web.Mvc;

namespace ControllersAndActions.Infrastructure
{
    public class CustomRedirectResult : ActionResult
    {
        public string Url { set; get; }

        public override void ExecuteResult(ControllerContext context)
        {
            string fullUrl = UrlHelper.GenerateContentUrl(Url, context.HttpContext);
            context.HttpContext.Response.Redirect(fullUrl);
        }
    }
}