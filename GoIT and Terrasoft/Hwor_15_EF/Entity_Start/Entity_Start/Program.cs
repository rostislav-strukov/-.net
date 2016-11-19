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
            Database.SetInitializer(new DropCreateDatabaseAlways<ModelDB>());

            ModelDB myDB = new ModelDB();

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
            myDB.SaveChanges();

            ShowALLProducts();
            ShowMenu();
            

            Console.ReadKey();

        }
        static void ShowALLProducts()
        {
            ModelDB myDB = new ModelDB();

            Console.WriteLine("List of product in DataBase -> Table[Product]:");
            Console.WriteLine(new string('-', 70));

            foreach (var item in myDB.TableProduct)
            {
                Console.WriteLine($"ProductId - {item.Id} NameProduct - {item.NameProd} PriceProduct - {item.ProdPrice}");
            }

            Console.WriteLine(new string('-', 70));
        }
        static void ShowMenu()
        {
            Console.WriteLine("PLease enter you choose:");
            Console.WriteLine("1 - Add new Product");
            Console.WriteLine("2 - Delete Product by ID");
            Console.WriteLine("3 - Create new Order");
            Console.WriteLine("4 - Search Product by name and price");
            Console.WriteLine("5 - Correct product by ProductID");
            Console.WriteLine("6 - Search element by ProductID");
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("0 - EXIT");

            int _triger = 0;
            string _check = Console.ReadLine();
            bool _parse = Int32.TryParse(_check, out _triger);

            if (_parse)
            {
                switch (_triger)
                {
                    case 1:
                        AddNewProduct();
                        break;
                    case 2:
                        RemoveProduct();
                        break;
                    case 3:
                        CreateNewOrder();
                        break;
                    case 4:
                        SearchProduct();
                        break;
                    case 5:
                        CorrectProduct();
                        break;
                    case 6:
                        SearchElemId();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("NOT right, please try again [1], [2], [3], [4], [5], [6] or [0]");
                        break;
                }
            }
            else
            {
                Console.WriteLine("NOT right, please try again [1], [2], [3], [4], [5], [6] or [0]");
            }
        }
        static void AddNewProduct()
        {
            ModelDB myDB = new ModelDB();
            Product product = new Product();

            Console.Write("Please add NAME of PRODUCT:");
            product.NameProd = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please add PRICE of PRODUCT");
            product.ProdPrice = Convert.ToDecimal(Console.ReadLine());

            myDB.TableProduct.Add(product);
            myDB.SaveChanges();
        }
        static void RemoveProduct()
        {
            ModelDB myDB = new ModelDB();

            int id = 0;

            Console.Write("Please choose Product by ID and DELETE:");
            id = Convert.ToInt32(Console.ReadLine());

            Product product = myDB.TableProduct.Find(id);

            myDB.TableProduct.Remove(product);
            myDB.SaveChanges();
        }
        static void CreateNewOrder()
        {

            int id = 0;
            int _quantity = 0;
            string _customer = null;

            ModelDB myDB = new ModelDB();

            Console.WriteLine("Please enter name customer which ordering:");
            _customer = Console.ReadLine();
            Console.WriteLine("Please choose ID/number product in list:");
            id = Convert.ToInt32(Console.ReadLine());
            Product product = myDB.TableProduct.Find(id);
            Console.WriteLine($"You choose product {product.Id}. {product.NameProd} -> Price: {product.ProdPrice}");
            Console.WriteLine("Please enter value quantity the product:");
            _quantity = Convert.ToInt32(Console.ReadLine());

            Order order = new Order()
            {
                Customer = _customer,
                ProductId = product.Id,
                Quantity = _quantity,
                Product = product
            };

            myDB.TableOrder.Add(order);
            myDB.SaveChanges();

            var orders = myDB.TableOrder.ToList();

            foreach (var item in orders)
            {
                Console.WriteLine("Congratulate you are purchased info");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"Name customer: {item.Customer}");
                Console.WriteLine($"OrderID: {item.Id} - ProductID: {item.ProductId} - Name Product: {item.Product.NameProd} - Quantity: {item.Quantity} - Total Price: {item.TotalPrice}");
            }
        }
        static void SearchProduct()
        {
            ModelDB myDB = new ModelDB();
            Product product = new Product();

            Console.WriteLine("Please enter name Product wich get info: ");
            product.NameProd = Console.ReadLine();
            Console.WriteLine("Please enter max Price wich get info about Product:");
            product.ProdPrice = Convert.ToDecimal(Console.ReadLine());

            var products = from item in myDB.TableProduct
                           where item.NameProd.Contains(product.NameProd)
                           where item.ProdPrice < product.ProdPrice
                           select item;

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Id}. {item.NameProd} - {item.ProdPrice}");
            }
        }
        static void CorrectProduct()
        {
            int id = 0;
            string _name = null;
            decimal _price = 0;

            ModelDB myDB = new ModelDB();

            Console.WriteLine("Please enter ProductID which you want correct:");
            id = Convert.ToInt32(Console.ReadLine());
            Product product = myDB.TableProduct.Find(id);

            Console.WriteLine("Please correct NameProduct");
            _name = Console.ReadLine();
            product.NameProd = _name;
            Console.WriteLine("Please correct ProdPrice");
            _price = Convert.ToDecimal(Console.ReadLine());
            product.ProdPrice = _price;
            myDB.Entry(product).State = EntityState.Modified;
            myDB.SaveChanges();
        }
        static void SearchElemId()
        {
            int id = 0;

            ModelDB myDB = new ModelDB();

            Console.WriteLine("Please enter ProductID which you want correct:");
            id = Convert.ToInt32(Console.ReadLine());
            Product product = myDB.TableProduct.Find(id);
            Console.WriteLine($"{product.Id}. {product.NameProd} - {product.ProdPrice}");
            myDB.SaveChanges();
        }
    }
}
