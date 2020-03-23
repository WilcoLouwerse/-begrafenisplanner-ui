using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using begrafenisplanner.Models;
using RestSharp;
using Newtonsoft.Json;

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
            ViewBag.Graves = GetGraves();

            return View();
        }

        public async Task<IActionResult> WriteGrave()
        {
            //ViewBag.GraveCovers = GetGraveCovers(); //For selecting a GraveCover from a DropDown with GraveCovers.
;
            return View();
        }

        public async Task<IActionResult> ReadGraveCover()
        {
            ViewBag.GraveCovers = GetGraveCovers();

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
            grave.deceased = Request.Form["Deceased"];
            grave.location = Request.Form["Location"];
            grave.position = int.Parse(Request.Form["Position"]);
            grave.graveType = Request.Form["GraveType"];
            grave.status = Request.Form["Status"];
            grave.acquisition = Request.Form["Acquisition"];
            grave.description = Request.Form["Description"];
            grave.dateCreated = DateTime.Today;
            grave.dateModified = DateTime.Today;

            PostGrave(grave);

            return RedirectToAction("WriteGrave");
        }

        public async Task<IActionResult> WriteGraveCoverButton()
        {
            GraveCover graveCover = new GraveCover();
            graveCover.name = Request.Form["Name"];
            graveCover.description = Request.Form["Description"];
            graveCover.dateCreated = DateTime.Today;
            graveCover.dateModified = DateTime.Today;

            PostGraveCover(graveCover);

            return RedirectToAction("WriteGraveCover");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }

        public DataTable GetGraves()
        {
            var client = new RestClient(apiConnector.grcApiUrl + "graves");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "45c1a4b6-59d3-4a6e-86bf-88a872f35845");
            IRestResponse response = client.Execute(request);

            DataTable dt = (DataTable) JsonConvert.DeserializeObject(response.Content, (typeof(DataTable)));

            Debug.WriteLine("\nGraves GET Response:\n" + response.Content + "\n");

            return dt;
        }

        public void PostGrave(Grave grave)
        {
            var client = new RestClient(apiConnector.grcApiUrl + "graves");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "45c1a4b6-59d3-4a6e-86bf-88a872f35845");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\"dateCreated\": \"" + grave.dateCreated.ToString("yyyy'-'MM'-'dd'T'HH:mm:ss.fff")
                                                            + "\",\"dateModified\": \"" + grave.dateModified.ToString("yyyy'-'MM'-'dd'T'HH:mm:ss.fff")
                                                            + "\",\"description\": \"" + grave.description
                                                            + "\",\"cemetery\": \"" + grave.cemetery
                                                            + "\",\"deceased\": \"" + grave.deceased
                                                            + "\",\"acquisition\": \"" + grave.acquisition
                                                            + "\",\"graveReference\": \"" + grave.reference
                                                            + "\",\"graveType\": \"" + grave.graveType
                                                            + "\",\"status\": \"" + grave.status
                                                            + "\",\"location\": \"" + grave.location
                                                            + "\",\"position\": " + grave.position 
                                                            + "}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            Debug.WriteLine("\nGraves POST Response:\n" + response.Content + "\n");
        }

        public DataTable GetGraveCovers()
        {
            var client = new RestClient(apiConnector.grcApiUrl + "grave_covers");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "45c1a4b6-59d3-4a6e-86bf-88a872f35845");
            IRestResponse response = client.Execute(request);

            DataTable dt = (DataTable)JsonConvert.DeserializeObject(response.Content, (typeof(DataTable)));

            Debug.WriteLine("\nGrave Covers GET Response:\n" + response.Content + "\n");

            return dt;
        }

        public void PostGraveCover(GraveCover graveCover)
        {
            var client = new RestClient(apiConnector.grcApiUrl + "grave_covers");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "45c1a4b6-59d3-4a6e-86bf-88a872f35845");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\"dateCreated\": \"" + graveCover.dateCreated.ToString("yyyy'-'MM'-'dd'T'HH:mm:ss.fff")
                                                            + "\",\"dateModified\": \"" + graveCover.dateModified.ToString("yyyy'-'MM'-'dd'T'HH:mm:ss.fff")
                                                            + "\",\"name\": \"" + graveCover.name
                                                            + "\",\"description\": \"" + graveCover.description
                                                            + "\"}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            Debug.WriteLine("\nGrave Covers POST Response:\n" + response.Content + "\n");
        }
    }
}
