using MVCWebServiceDemo.Models;
using MVCWebServiceDemo.Utils;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System;
using System.Web.Http.Cors;

namespace MVCWebServiceDemo.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class LocationController : ApiController
    {
       
        private List<Location> allLocations;

        [HttpGet]
        [Route("Trips/City/{id}")]
        public HttpResponseMessage GetData(int id)
        {
            JSONReadWrite readWrite = new JSONReadWrite();
            List<Location> locations = new List<Location>();
            var strFormato = DateTime.Now.Date.ToString("yyyy-MM-dd");
            var date = DateTime.ParseExact(strFormato, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            locations = JsonConvert.DeserializeObject<List<Location>>(readWrite.Read("trips.json", "data"));
            allLocations = locations.FindAll(x => x.city.id == id && x.date > date);
            return Request.CreateResponse(HttpStatusCode.OK, allLocations, Configuration.Formatters.JsonFormatter);
        }

    }
}
