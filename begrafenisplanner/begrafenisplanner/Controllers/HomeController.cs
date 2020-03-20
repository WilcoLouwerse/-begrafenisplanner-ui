using System;
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
            return View();
        }

        public async Task<IActionResult> ReadGrave()
        {
            var client = new RestClient(apiConnector.grcApiUrl + "graves");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "45c1a4b6-59d3-4a6e-86bf-88a872f35845");
            IRestResponse response = client.Execute(request);
            
            Debug.WriteLine("\nGraves GET Response:\n"+response.Content+"\n");

            return View();
        }

        public async Task<IActionResult> WriteGrave()
        {
            return View();
        }

        public async Task<IActionResult> ReadGraveCover()
        {
            var client = new RestClient(apiConnector.grcApiUrl + "grave_covers");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "45c1a4b6-59d3-4a6e-86bf-88a872f35845");
            IRestResponse response = client.Execute(request);
            
            Debug.WriteLine("\nGrave Covers GET Response:\n" + response.Content + "\n");

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
            grave.location = Request.Form["Location"];
            grave.position = Request.Form["Position"];
            grave.graveType = Request.Form["GraveType"];
            grave.status = Request.Form["Status"];
            grave.acquisition = Request.Form["Acquisition"];
            grave.description = Request.Form["Description"];
            grave.dateCreated = DateTime.Today;
            grave.dateModified = DateTime.Today;

            // var client = new RestClient(apiConnector.grcApiUrl + "graves");
            // client.Timeout = -1;
            // var request = new RestRequest(Method.POST);
            // request.AddHeader("Authorization", "45c1a4b6-59d3-4a6e-86bf-88a872f35845");
            // request.AddHeader("Content-Type", "application/json");
            // request.AddParameter("application/json", "{\n\t\"dateCreated\": \"2020-03-19 14:16:31\",\n\t\"dateModified\": \"2020-03-19 14:16:31\",\n\t\"description\": \"Test Graf\",\n\t\"cemetery\": \"url cemetery\",\n\t\"acquisition\": \"url acquisition\",\n\t\"graveReference\": \"zb-03\",\n\t\"graveType\": \"url grave type\",\n\t\"status\": \"in use\",\n\t\"location\": \"url location\",\n\t\"position\": 1,\n\t\"graveCoverId\": \"45c1a4b6-59d3-4a6e-86bf-88a872f35843\"}", ParameterType.RequestBody);
            // IRestResponse response = client.Execute(request);
            
            // Debug.WriteLine("\nGraves POST Response:\n" + response.Content + "\n");

            return RedirectToAction("WriteGrave");
        }
        public async Task<IActionResult> WriteGraveCoverButton()
        {
            GraveCover graveCover = new GraveCover();
            graveCover.name = Request.Form["Name"];
            graveCover.description = Request.Form["Description"];
            graveCover.dateCreated = DateTime.Today;
            graveCover.dateModified = DateTime.Today;

            var client = new RestClient(apiConnector.grcApiUrl + "grave_covers");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "45c1a4b6-59d3-4a6e-86bf-88a872f35845");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\"dateCreated\": \"" + graveCover.dateCreated 
                                                            + "\",\"dateModified\": \"" + graveCover.dateModified 
                                                            + "\",\"name\": \"" + graveCover.name 
                                                            + "\",\"description\": \"" + graveCover.description + "\"}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            
            Debug.WriteLine("\nGrave Covers POST Response:\n" + response.Content + "\n");

            return RedirectToAction("WriteGraveCover");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
