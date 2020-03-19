using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using begrafenisplanner.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using RestSharp;

namespace begrafenisplanner.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var client1 = new RestClient("http://localhost:31500/grave_covers");
            client1.Timeout = -1;
            var request1 = new RestRequest(Method.POST);
            request1.AddHeader("Authorization", "45c1a4b6-59d3-4a6e-86bf-88a872f35845");
            request1.AddHeader("API-Version", "");
            request1.AddHeader("X-NLX-Logrecord-ID", "");
            request1.AddHeader("X-NLX-Request-Process-Id", "");
            request1.AddHeader("X-NLX-Request-Data-Elements", "");
            request1.AddHeader("X-NLX-Request-Data-Subject", "");
            request1.AddHeader("X-NLX-Audit-Clarification", "");
            request1.AddHeader("Content-Type", "application/json");
            request1.AddParameter("application/json", "{\n    \"dateCreated\": \"20200101\",\n    \"dateModified\": \"20200101\",\n    \"name\": \"Enkel monument\",\n    \"description\": \"gemaakt van marmer\"}", ParameterType.RequestBody);
            IRestResponse response1 = client1.Execute(request1);
            Debug.WriteLine("\n"+response1.Content+"\n");

            //request.AddParameter("application/json", "{\n\t\"name\": \"My Offer\",\n\t\"product\":\"/products/{{product}}\",\n\t\"price\": \"50.00\",\n\t\"taxPercentage\": 9,\n\t\"priceCurrency\": \"EUR\",\n\t\"offeredBy\": \"http://example.org/orgs/org1\",\n\t\"availabilityEnds\":\"20191231\",\n\t\"availabilityStarts\":\"20190101\",\n\t\"eligibleCustomerTypes\": [\"/customer_types/{{customerType}}\"]\n}",

            // var client = new RestClient("http://localhost:31500/graves");
            // client.Timeout = -1;
            // var request = new RestRequest(Method.POST);
            // request.AddHeader("Authorization", "45c1a4b6-59d3-4a6e-86bf-88a872f35845");
            // request.AddHeader("API-Version", "");
            // request.AddHeader("X-NLX-Logrecord-ID", "");
            // request.AddHeader("X-NLX-Request-Process-Id", "");
            // request.AddHeader("X-NLX-Request-Data-Elements", "");
            // request.AddHeader("X-NLX-Request-Data-Subject", "");
            // request.AddHeader("X-NLX-Audit-Clarification", "");
            // request.AddHeader("Content-Type", "application/json");
            // request.AddParameter("application/json", "{\n    \"dateCreated\": \"2020-03-19 14:16:31\",\n    \"dateModified\": \"2020-03-19 14:16:31\",\n    \"description\": \"Test Graf\",\n    \"cemetery\": \"url cemetery\",\n    \"acquisition\": \"url acquisition\",\n    \"graveReference\": \"zb-03\",\n    \"graveType\": \"url grave type\",\n    \"status\": \"in use\",\n    \"location\": \"url location\",\n    \"position\": 1,\n    \"graveCoverId\": \"45c1a4b6-59d3-4a6e-86bf-88a872f35843\"}", ParameterType.RequestBody);
            // IRestResponse response = client.Execute(request);
            // Debug.WriteLine("\n"+response.Content+"\n");

            return View();
        }
        public async Task<IActionResult> Response()
        {
            var client = new RestClient("http://localhost:31500/grave_covers");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "45c1a4b6-59d3-4a6e-86bf-88a872f35845");
            request.AddHeader("API-Version", "");
            request.AddHeader("X-NLX-Logrecord-ID", "");
            request.AddHeader("X-NLX-Request-Process-Id", "");
            request.AddHeader("X-NLX-Request-Data-Elements", "");
            request.AddHeader("X-NLX-Request-Data-Subject", "");
            request.AddHeader("X-NLX-Audit-Clarification", "");
            request.AddHeader("Link", "");
            IRestResponse response = client.Execute(request);
            Debug.WriteLine("\n"+response.Content+"\n");

            // var apiURL = "http://test.htasoftware.eu/acm/api/";
            // var ApiUesrName = "ACMAPI";
            // var ApiPassword = "Narrowcast";
            // var loginRequest = new LoginRequest() { Username = ApiUesrName, Password = ApiPassword };
            // AirwayBillResponse airwayBillResponse = null;
            // string airwayBillResponseString = null;
            // var buffer = System.Text.Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(loginRequest));
            // var byteContent = new ByteArrayContent(buffer);
            // byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            //
            // using (var client = new HttpClient())
            // {
            //     HttpResponseMessage response = await client.PostAsync($"{apiURL}APILogin", byteContent);
            //     if (response.IsSuccessStatusCode)
            //     {
            //         string content = await response.Content.ReadAsAsync<string>();
            //
            //         var bearerToken = $"Bearer {content}";
            //         client.DefaultRequestHeaders.Add("Authorization", bearerToken);
            //
            //         var response2 = await client.GetAsync($"{apiURL}AirwayBillStockAPI/{token.airwayBillToken}");
            //         if (response2.IsSuccessStatusCode)
            //         {
            //             airwayBillResponse = await response2.Content.ReadAsAsync<AirwayBillResponse>();
            //         }
            //
            //         airwayBillResponseString = (new JavaScriptSerializer()).Serialize(airwayBillResponse);
            //         Debug.WriteLine(airwayBillResponseString);
            //         Debug.WriteLine(" Press any key---------------------/////////////////////////////////////");
            //
            //
            //     }
            //
            // }
            // ViewBag.AirwayBillResponse = airwayBillResponse;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> temp()
        {
            return RedirectToAction("Response");
        }
    }
}
