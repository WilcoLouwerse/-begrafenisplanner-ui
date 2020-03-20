using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using begrafenisplanner.Models;
using RestSharp;

namespace begrafenisplanner.Controllers
{
    public class HomeController : Controller
    {
        ApiConnector apiConnector = new ApiConnector();
        public IActionResult Index()
        {
            return View(); //TEMP TODO

            var client1 = new RestClient(apiConnector.grcApiUrl + "grave_covers");
            client1.Timeout = -1;
            var request1 = new RestRequest(Method.POST);
            request1.AddHeader("Authorization", "45c1a4b6-59d3-4a6e-86bf-88a872f35845");
            // request1.AddHeader("API-Version", "V.0.1");
            // request1.AddHeader("X-NLX-Logrecord-ID", "");
            // request1.AddHeader("X-NLX-Request-Process-Id", "");
            // request1.AddHeader("X-NLX-Request-Data-Elements", "");
            // request1.AddHeader("X-NLX-Request-Data-Subject", "");
            // request1.AddHeader("X-NLX-Audit-Clarification", "");
            request1.AddHeader("Content-Type", "application/json");
            request1.AddParameter("application/json", "{\n\t\"dateCreated\": \"20200101\",\n\t\"dateModified\": \"20200101\",\n\t\"name\": \"Enkel monument\",\n\t\"description\": \"gemaakt van marmer\"\n}", ParameterType.RequestBody);
            IRestResponse response1 = client1.Execute(request1);
            Debug.WriteLine("\n"+response1.Content+"\n");

            //request.AddParameter("application/json", "{\n\t\"name\": \"My Offer\",\n\t\"product\":\"/products/{{product}}\",\n\t\"price\": \"50.00\",\n\t\"taxPercentage\": 9,\n\t\"priceCurrency\": \"EUR\",\n\t\"offeredBy\": \"http://example.org/orgs/org1\",\n\t\"availabilityEnds\":\"20191231\",\n\t\"availabilityStarts\":\"20190101\",\n\t\"eligibleCustomerTypes\": [\"/customer_types/{{customerType}}\"]\n}",
            //request.AddParameter("application/json", "{\n\t\"name\": \"My Group\",\n    \"sourceOrganization\": \"002851234\",\n    \"catalogue\": \"/catalogues/\"\n}",  ParameterType.RequestBody);

            // var client = new RestClient(apiConnector.grcApiUrl + "graves");
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
        public async Task<IActionResult> ReadGrave()
        {
            // var client = new RestClient(apiConnector.grcApiUrl + "graves");
            // client.Timeout = -1;
            // var request = new RestRequest(Method.GET);
            // request.AddHeader("Authorization", "45c1a4b6-59d3-4a6e-86bf-88a872f35845");
            // // request.AddHeader("API-Version", "");
            // // request.AddHeader("X-NLX-Logrecord-ID", "");
            // // request.AddHeader("X-NLX-Request-Process-Id", "");
            // // request.AddHeader("X-NLX-Request-Data-Elements", "");
            // // request.AddHeader("X-NLX-Request-Data-Subject", "");
            // // request.AddHeader("X-NLX-Audit-Clarification", "");
            // request.AddHeader("Link", "");
            // IRestResponse response = client.Execute(request);
            //
            // Debug.WriteLine("\nGraves GET Response:\n"+response.Content+"\n");

            return View();
        }

        public async Task<IActionResult> WriteGrave()
        {
            return View();
        }

        public async Task<IActionResult> ReadGraveCover()
        {
            // var client = new RestClient(apiConnector.grcApiUrl + "grave_covers");
            // client.Timeout = -1;
            // var request = new RestRequest(Method.GET);
            // request.AddHeader("Authorization", "45c1a4b6-59d3-4a6e-86bf-88a872f35845");
            // // request.AddHeader("API-Version", "");
            // // request.AddHeader("X-NLX-Logrecord-ID", "");
            // // request.AddHeader("X-NLX-Request-Process-Id", "");
            // // request.AddHeader("X-NLX-Request-Data-Elements", "");
            // // request.AddHeader("X-NLX-Request-Data-Subject", "");
            // // request.AddHeader("X-NLX-Audit-Clarification", "");
            // request.AddHeader("Link", "");
            // IRestResponse response = client.Execute(request);
            //
            // Debug.WriteLine("\nGrave Covers GET Response:\n" + response.Content + "\n");

            return View();
        }

        public async Task<IActionResult> WriteGraveCover()
        {
            return View();
        }

        public async Task<IActionResult> WriteGraveButton()
        {
            Grave grave = new Grave();
            grave.reference = Request.Form["Reference"];
            grave.cemetery = Request.Form["Cemetery"];

            // var client = new RestClient(apiConnector.grcApiUrl + "graves");
            // client.Timeout = -1;
            // var request = new RestRequest(Method.POST);
            // request.AddHeader("Authorization", "45c1a4b6-59d3-4a6e-86bf-88a872f35845");
            // // request.AddHeader("API-Version", "V.0.1");
            // // request.AddHeader("X-NLX-Logrecord-ID", "");
            // // request.AddHeader("X-NLX-Request-Process-Id", "");
            // // request.AddHeader("X-NLX-Request-Data-Elements", "");
            // // request.AddHeader("X-NLX-Request-Data-Subject", "");
            // // request.AddHeader("X-NLX-Audit-Clarification", "");
            // request.AddHeader("Content-Type", "application/json");
            // request.AddParameter("application/json", "{\n\t\"dateCreated\": \"2020-03-19 14:16:31\",\n\t\"dateModified\": \"2020-03-19 14:16:31\",\n\t\"description\": \"Test Graf\",\n\t\"cemetery\": \"url cemetery\",\n\t\"acquisition\": \"url acquisition\",\n\t\"graveReference\": \"zb-03\",\n\t\"graveType\": \"url grave type\",\n\t\"status\": \"in use\",\n\t\"location\": \"url location\",\n\t\"position\": 1,\n\t\"graveCoverId\": \"45c1a4b6-59d3-4a6e-86bf-88a872f35843\"}", ParameterType.RequestBody);
            // IRestResponse response = client.Execute(request);
            //
            // Debug.WriteLine("\nGraves POST Response:\n" + response.Content + "\n");

            return RedirectToAction("WriteGrave");
        }
        public async Task<IActionResult> WriteGraveCoverButton()
        {
            GraveCover graveCover = new GraveCover();
            graveCover.name = Request.Form["Name"];
            graveCover.description = Request.Form["Description"];

            // var client = new RestClient(apiConnector.grcApiUrl + "grave_covers");
            // client.Timeout = -1;
            // var request = new RestRequest(Method.POST);
            // request.AddHeader("Authorization", "45c1a4b6-59d3-4a6e-86bf-88a872f35845");
            // // request.AddHeader("API-Version", "V.0.1");
            // // request.AddHeader("X-NLX-Logrecord-ID", "");
            // // request.AddHeader("X-NLX-Request-Process-Id", "");
            // // request.AddHeader("X-NLX-Request-Data-Elements", "");
            // // request.AddHeader("X-NLX-Request-Data-Subject", "");
            // // request.AddHeader("X-NLX-Audit-Clarification", "");
            // request.AddHeader("Content-Type", "application/json");
            // request.AddParameter("application/json", "{\n\t\"dateCreated\": \"20200101\",\n\t\"dateModified\": \"20200101\",\n\t\"name\": \"Enkel monument\",\n\t\"description\": \"gemaakt van marmer\"\n}", ParameterType.RequestBody);
            // IRestResponse response = client.Execute(request);
            //
            // Debug.WriteLine("\nGrave Covers POST Response:\n" + response.Content + "\n");

            return RedirectToAction("WriteGraveCover");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
