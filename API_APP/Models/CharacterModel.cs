using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace API_APP.Models
{
    [DataContract]
    public class CharacterModel
    {
        [DataMember(Name = "_id")]
        public string id { get; set; }

        [DataMember(Name = "height")]
        public string height { get; set; }

        [DataMember(Name = "race")]
        public string race { get; set; }

        [DataMember(Name = "gender")]
        public string gender { get; set; }

        [DataMember(Name = "birth")]
        public string birth { get; set; }

        [DataMember(Name = "spouse")]
        public string spouse { get; set; }

        [DataMember(Name = "death")]
        public string death { get; set; }

        [DataMember(Name = "name")]
        public string name { get; set; }

        [DataMember(Name = "wikiUrl")]
        public string wikiUrl { get; set; }
    }
}



