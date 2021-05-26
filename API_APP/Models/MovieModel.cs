using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace API_APP.Models
{
    [DataContract]
    public class MovieModel
    {
        [DataMember(Name = "_id")]
        public string id { get; set; }

        [DataMember(Name = "name")]
        public string name { get; set; }

        [DataMember(Name = "runtimeInMinutes")]
        public int runtimeInMinutes { get; set; }

        [DataMember(Name = "budgetInMillions")]
        public int budgetInMillions { get; set; }

        [DataMember(Name = "boxOfficeRevenueInMillions")]
        public int boxOfficeRevenueInMillions { get; set; }

        [DataMember(Name = "academyAwardWins")]
        public int academyAwardWins { get; set; }

    }
}