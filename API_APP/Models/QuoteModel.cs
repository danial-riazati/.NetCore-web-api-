using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace API_APP.Models
{
    [DataContract]
    public class QuoteModel
    {
        [DataMember(Name ="_id")]
        public string id { get; set; }

        [DataMember(Name = "dialog")]
        public string dialog { get; set; }

        [DataMember(Name = "movie")]
        public string movie { get; set; }

        [DataMember(Name = "character")]
        public string character { get; set; }

    }
}