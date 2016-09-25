using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Start
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<HubDB>());

            using (HubDB myDB = new HubDB())
            {
                Product prod1 = new Product { NameProd = "MicrosoftTablet", ProdPrice = 10000 };
                Product prod2 = new Product { NameProd = "SumsungTablet", ProdPrice = 7000 };
                Product prod3 = new Product { NameProd = "AppleTablet", ProdPrice = 9000 };
                Product prod4 = new Product { NameProd = "AsusTablet", ProdPrice = 5000 };
                Product prod5 = new Product { NameProd = "ChuviTablet", ProdPrice = 1500 };

                myDB.TableProduct.Add(prod1);
                myDB.TableProduct.Add(prod2);
                myDB.TableProduct.Add(prod3);
                myDB.TableProduct.Add(prod4);
                myDB.TableProduct.Add(prod5);
            }
        }
    }
}
