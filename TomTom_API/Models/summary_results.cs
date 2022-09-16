using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomTom_API.Models
{
    public class summary_results
    {
        public summary_details summary { get; set; }

        public IList<result_details> results { get; set; }
    }

    public class summary_details
    {

        public string query { get; set; }
        public string queryType { get; set; }
        public int queryTime { get; set; }
        public int numResults { get; set; }
        public int offset { get; set; }
        public long totalResults { get; set; }
        public int fuzzyLevel { get; set; }
    }

    public class result_details
    {
        public string type { get; set; }
        public string id { get; set; }
        public double score { get; set; }
        public string entityType { get; set; }

        public matchConfidence_details matchConfidence { get; set; }
        public address_details address { get; set; }
        public position_details position { get; set; }
        public viewport_details viewport { get; set; }

        public viewport_details boundingBox { get; set; }
        public viewport_details dataSources { get; set; }
    }
    public class matchConfidence_details
    {
        public decimal score { get; set; }
    }
    public class address_details
    {
        public string municipality { get; set; }
        public string countrySecondarySubdivision { get; set; }
        public string countrySubdivision { get; set; }
        public string postalCode { get; set; }
        public string extendedPostalCode { get; set; }
        public string countryCode { get; set; }
        public string country { get; set; }
        public string countryCodeISO3 { get; set; }
        public string freeformAddress { get; set; }
    }
    public class position_details
    {
        public decimal lat { get; set; }
        public decimal lon { get; set; }
    }
    public class viewport_details
    {
        public position_details topLeftPoint { get; set; }
        public position_details btmRightPoint { get; set; }
    }
    public class dataSources_details
    {
        public id_details geometry { get; set; }
    }
    public class id_details
    {
        public string id { get; set; }
    }
}
