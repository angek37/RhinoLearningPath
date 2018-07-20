using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Reflection;
using System.Web;
using System.Web.Routing;

namespace UrlsAndRoutes.Tests
{
    [TestClass]
    public class RouteTests
    {

        private HttpContextBase createHttpContextBase(string targetUrl = null, 
                                                    string httpMethod = "GET")
        {
            // Create the mock request
            Mock<HttpRequestBase> mockRequest = new Mock<HttpRequestBase>();
            mockRequest.Setup(m => m.AppRelativeCurrentExecutionFilePath)
                .Returns(targetUrl);
            mockRequest.Setup(m => m.HttpMethod).Returns(httpMethod);

            // Create the mock response
            Mock<HttpResponseBase> mockResponse = new Mock<HttpResponseBase>();
            mockResponse.Setup(m => m.ApplyAppPathModifier(
                It.IsAny<string>())).Returns<string>(s => s);

            // Create the mock context, using the request and response
            Mock<HttpContextBase> mockContext = new Mock<HttpContextBase>();
            mockContext.Setup(m => m.Request).Returns(mockRequest.Object);
            mockContext.Setup(m => m.Response).Returns(mockResponse.Object);

            // Return the mocked context
            return mockContext.Object;
        }

        private void TestRouteMatch(string url, string controller, string action,
            object routeProperties = null, string httpMethod = "GET")
        {
            // Arrange
            RouteCollection routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);
            // Act - process the route
            RouteData result = routes.GetRouteData(createHttpContextBase(url, httpMethod));
            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(TestIncomingRouteResult(result, controller,
                action, routeProperties));
        }

        private bool TestIncomingRouteResult(RouteData routeResult,
            string controller, string action, object propertySet = null)
        {
            Func<object, object, bool> valCompare = (v1, v2) =>
            {
                return StringComparer.InvariantCultureIgnoreCase
                           .Compare(v1, v2) == 0;
            };

            bool result = valCompare(routeResult.Values["controller"], controller)
                          && valCompare(routeResult.Values["action"], action);

            if (propertySet != null)
            {
                PropertyInfo[] propInfo = propertySet.GetType().GetProperties();
                foreach (var pi in propInfo)
                {
                    if (!(routeResult.Values.ContainsKey(pi.Name)
                        && valCompare(routeResult.Values[pi.Name],
                              pi.GetValue(propertySet, null))))
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        private void TestRouteFail(string url)
        {
            // Arrange
            RouteCollection routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);
            // Act - process the route
            RouteData result = routes.GetRouteData(createHttpContextBase(url));
            // Assert
            Assert.IsTrue(result == null || result.Route == null);
        }

        //[TestMethod]
        //public void TestIncomingRoutes()
        //{
        //    // check for the URL that is hoped for
        //    TestRouteMatch("~/Admin/Index", "Admin", "Index");
        //    // check that the values are being obtained from the segments
        //    TestRouteMatch("~/One/Two", "One", "Two");

        //    // ensure that too many or too few segments failt to match
        //    TestRouteFail("~/Admin/Index/Segment");
        //    TestRouteFail("~/Admin");
        //}

        //[TestMethod]
        //public void TestIncomingRoutes()
        //{
        //    TestRouteMatch("~/", "Home", "Index");
        //    TestRouteMatch("~/Customer", "Customer", "Index");
        //    TestRouteMatch("~/Customer/List", "Customer", "List");
        //    TestRouteFail("~/Customer/List/All");
        //}

        //[TestMethod]
        //public void TestIncomingRoutes()
        //{
        //    TestRouteMatch("~/", "Home", "Index");
        //    TestRouteMatch("~/Customer", "Customer", "Index");
        //    TestRouteMatch("~/Customer/List", "Customer", "List");
        //    TestRouteFail("~/Customer/List/All");
        //    TestRouteMatch("~/Shop/Index", "Home", "Index");
        //}

        //[TestMethod]
        //public void TestIncomingRoutes()
        //{
        //    TestRouteMatch("~/", "Home", "Index", new {id = "DefaultId"});
        //    TestRouteMatch("~/Customer", "Customer", "index", new {id = "DefaultId"});
        //    TestRouteMatch("~/Customer/List", "Customer", "List",
        //        new {id = "DefaultId"});
        //    TestRouteMatch("~/Customer/List/All", "Customer", "List", new {id = "All"});
        //    TestRouteFail("~/Customer/List/All/Delete");
        //}

        //[TestMethod]
        //public void TestIncomingRoutes()
        //{
        //    TestRouteMatch("~/", "Home", "Index");
        //    TestRouteMatch("~/Customer", "Customer", "Index");
        //    TestRouteMatch("~/Customer/List", "Customer", "List");
        //    TestRouteMatch("~/Customer/List/All", "Customer", "List", new {id = "All"});
        //    TestRouteFail("~/Customer/List/All/Delete");
        //}

        //[TestMethod] // Añade *catchall la ruta puede tener cuantos segmentos quiera
        //public void TestIncomingRoutes()
        //{
        //    TestRouteMatch("~/", "Home", "Index");
        //    TestRouteMatch("~/Customer", "Customer", "Index");
        //    TestRouteMatch("~/Customer/List", "Customer", "List");
        //    TestRouteMatch("~/Customer/List/All", "Customer", "List", new {id = "All"});
        //    TestRouteMatch("~/Customer/List/All/Delete", "Customer", "List",
        //        new {id = "All", catchall = "Delete"});
        //    TestRouteMatch("~/Customer/List/All/Delete/Perm", "Customer", "List",
        //        new {id = "All", catchall = "Delete/Perm"});
        //}

        //[TestMethod] // Añade Constraints a las rutas con expresiones regulares
        //public void TestIncomingRoutes()
        //{
        //    TestRouteMatch("~/", "Home", "Index");
        //    TestRouteMatch("~/Home", "Home", "Index");
        //    TestRouteMatch("~/Home/Index", "Home", "Index");

        //    TestRouteMatch("~/Home/About", "Home", "About");
        //    TestRouteMatch("~/Home/About/MyId", "Home", "About", new {id = "MyId"});
        //    TestRouteMatch("~/Home/About/MyId/More/Segments", "Home", "About",
        //        new
        //        {
        //            id = "MyId",
        //            catchall = "More/Segments"
        //        });

        //    TestRouteFail("~/Home/OtherAction");
        //    TestRouteFail("~/Account/Index");
        //    TestRouteFail("~/Account/About");
        //}
    }
}
