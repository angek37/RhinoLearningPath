using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SoapTutorial
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "urn:Example1")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(MessageName = "twoparameter", Description = "Addition of two integers")]
        public int add(int a, int b)
        {
            return (a + b);
        }

        [WebMethod(MessageName = "threeparameter", Description = "Addition of three integers")]
        public int add(int a, int b, int c)
        {
            return (a + b + c);
        }
    }
}
