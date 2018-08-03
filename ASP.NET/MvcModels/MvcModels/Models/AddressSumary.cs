using System.Web.Mvc;
using MvcModels.Infrastructure;

namespace MvcModels.Models
{
    //[Bind(Include = "City")]
    [ModelBinder(typeof(AddressSummaryBinder))]
    public class AddressSumary
    {
        public string City { set; get; }
        public string Country { set; get; }
    }
}