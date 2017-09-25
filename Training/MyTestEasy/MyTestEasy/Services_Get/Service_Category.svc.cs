using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Linq;

namespace MyTestEasy.Services_Get
{
    [ServiceContract(Namespace = "MyTestEasy.Services_Get")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service_Category
    {

        private XDocument GetDb()
        {
            return XDocument.Load("Products_DB");
        }

        [OperationContract]
        public List<Category> GetAllCategories()
        {
            XDocument db = GetDb();

            List<Category> lstCategory = (from categories in db.Descendants("categories")
                                          select new Category()
                                          {
                                              categoryID = Convert.ToInt32(categories.Attribute("CategoryID").Value),
                                              name = categories.Element("name").Value,
                                              description = categories.Element("description").Value

                                          }).ToList<Category>();

            return lstCategory;

        }

        [OperationContract]
        public List<Category> GetCategoryInfo(string categoryKey)
        {
            List<Category> lst = GetAllCategories();

            lst = lst.Where(ctg => ctg.name == categoryKey).ToList<Category>();

            return lst;
        }

        [OperationContract]
        public List<Product> GetProducts(int ID)
        {
            XDocument db = GetDb();

            List<Product> lstProd = (from products in db.Descendants("products")
                                      select new Product()
                                      {
                                          productID = Convert.ToInt32(products.Attribute("ProductID").Value),
                                          name = products.Element("name").Value,
                                          cost = Convert.ToDecimal(products.Element("cost")),
                                          description = products.Element("description").Value,
                                          category = products.Element("category").Value
                                      }).ToList<Product>();

            lstProd = lstProd.Where(prod => prod.categoryID == ID).ToList<Product>();  
                   
            return lstProd;
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
