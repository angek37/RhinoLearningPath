using System.Net.Http;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {
        public async static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();

            //var httpTask = await client.GetAsync("http://apress.com");

            var httpMessage = await client.GetAsync("http://apress.com");

            // we could do other thing here we are waiting
            // for the HTTP request to complete

            //return httpTask.ContinueWith((Task<HttpResponseMessage> antecedent) => {
            //    return antecedent.Result.Content.Headers.ContentLength;
            //});
            return httpMessage.Content.Headers.ContentLength;
        }
    }
}