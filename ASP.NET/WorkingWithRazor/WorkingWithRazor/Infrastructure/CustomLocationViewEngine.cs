using System.Web.Mvc;

namespace WorkingWithRazor.Infrastructure
{
    public class CustomLocationViewEngine : RazorViewEngine
    {
        // Change the view search location 
        public CustomLocationViewEngine()
        {
            ViewLocationFormats = new string[]
            {
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Common/{0}.cshtml"
            };
        }
    }
}