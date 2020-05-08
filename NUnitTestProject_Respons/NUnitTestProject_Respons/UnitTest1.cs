using NUnit.Framework;
using Newtonsoft.Json;
using RestSharp;

namespace NUnitTestProject_Response
{
    public class Tests
    {
  
        [Test]
        public void Test1()
        {
            var client = new RestClient("https://disease.sh/v2/states/California");
            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");
            var r = client.Execute(request);
            Response DeserializeProduct = JsonConvert.DeserializeObject<Response>(r.Content);
            Assert.AreEqual (r.StatusCode, System.Net.HttpStatusCode.OK);
        }
    }
} 