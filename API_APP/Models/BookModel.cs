using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace API_APP.Models
{
    [DataContract]
    public class BookModel
    {
        [DataMember(Name ="_id")]
        public string id { get; set; }
        [DataMember(Name ="name")]
        public string name { get; set; }

    }
}