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
            Database.SetInitializer(new DropCreateDatabaseAlways<Model>());

            using (Model myDB = new Model())
            {
                Product prod1 = new Product { /*IdProduct = 1,*/ NameProd = "MicrosoftTablet", ProdPrice = 10000 };
                Product prod2 = new Product { /*IdProduct = 2,*/ NameProd = "SumsungTablet", ProdPrice = 7000 };
                Product prod3 = new Product { /*IdProduct = 3,*/ NameProd = "AppleTablet", ProdPrice = 9000 };
                Product prod4 = new Product { /*IdProduct = 4,*/ NameProd = "AsusTablet", ProdPrice = 5000 };
                Product prod5 = new Product { /*IdProduct = 5,*/ NameProd = "ChuviTablet", ProdPrice = 1500 };

                myDB.TableProduct.Add(prod1);
                myDB.TableProduct.Add(prod2);
                myDB.TableProduct.Add(prod3);
                myDB.TableProduct.Add(prod4);
                myDB.TableProduct.Add(prod5);

                myDB.SaveChanges();

                Console.WriteLine("Check is product");

                Order ord1 = new Order { Customer = "Fill", Quantity = 4, Product = prod1 };
                Order ord2 = new Order { Customer = "Mark", Quantity = 3, Product = prod2 };
                Order ord3 = new Order { Customer = "Oleg", Quantity = 5, Product = prod3 };
                Order ord4 = new Order { Customer = "Ivan", Quantity = 5, Product = prod4 };
                Order ord5 = new Order { Customer = "Babin", Quantity = 6, Product = prod5 };

                myDB.TableOrder.Add(ord1);
                myDB.TableOrder.Add(ord2);
                myDB.TableOrder.Add(ord3);
                myDB.TableOrder.Add(ord5);
                myDB.TableOrder.Add(ord5);

                myDB.SaveChanges();

                Console.WriteLine("Check is order");

                var query = from p in myDB.TableProduct
                            select p.NameProd;

                foreach (var item in query)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();
            }
        }
    }
}
