using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace API_APP.Models
{
    [DataContract]
    public class ChapterModel
    {
        [DataMember(Name = "_id")]
        public string id { get; set; }

        [DataMember(Name = "chapterName")]
        public string chapterName { get; set; }

        [DataMember(Name = "book")]
        public string book { get; set; }

    }
}