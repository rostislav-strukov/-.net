using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MyTestEasy.Services_Get
{
    [DataContract]
    public class Category
    {
        [DataMember]
        public int categoryID;
        [DataMember]
        public string name;
        [DataMember]
        public string description;

    }
}