using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MyTestEasy.Services_Get
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int productID;
        [DataMember]
        public int categoryID;
        [DataMember]
        public decimal cost;
        [DataMember]
        public string name;
        [DataMember]
        public string description;
        [DataMember]
        public string category;
    }
}