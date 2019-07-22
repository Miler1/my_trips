using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebServiceDemo.Models
{
    public class Location
    {
        public String hotelName { get; set; }
        public String thumb { get; set; }
        public int stars { get; set; }
        public String location { get; set; }
        public City city { get; set; }     
        public String country { get; set; }
        public DateTime date { get; set; }
        public Double price { get; set; }

        [JsonProperty("class")]
        public String class1 { get; set; }
        public int guest { get; set; }

    }

    public class Locations
    {
        public IList<Location> locations;
    }
}