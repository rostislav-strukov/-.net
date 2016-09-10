using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork_13
{
    class Program
    {
        static void Main(string[] args)
        {

            int _sizePage = 2;

            Article article = new Article();

            var repository = new List<Article>
            {

                new Article
                {
                    Id = 1,
                    Name = "новый Телефон",
                    Price = 300m,
                    ValueCount = 10,
                    Discount = 0.9m,
                    Sold = 5,
                    Sum = (article.Price * article.Discount) * article.Sold
                },

                new Article
                {
                    Id = 2,
                    Name = "PoketBook",
                    Price = 200,
                    ValueCount = 20,
                    Discount = 0.85m,
                    Sold = 12,
                    Sum = (article.Price * article.Discount) * article.Sold
                },
                new Article
                {
                    Id = 3,
                    Name = "NoteBook",
                    Price = 1500,
                    ValueCount = 5,
                    Discount = 0.95m,
                    Sold = 3,   
                },
                new Article
                {
                    Id = 4,
                    Name = "MFU Printer",
                    Price = 600,
                    ValueCount = 8,
                    Discount = 1m,
                    Sold = 7,
                    Sum = (article.Price * article.Discount) * article.Sold
                },
                new Article
                {
                    Id = 5,
                    Name = "SSD Disk",
                    Price = 800,
                    ValueCount = 10,
                    Discount = 0.9m,
                    Sold = 5,
                    Sum = (article.Price * article.Discount) * article.Sold
                }
            };

            var query =
                    from _article in repository
                    where _article.Discount < 1m && _article.Price < 1000 && _article.Sold > 2
                    orderby _article.Name
                    select new
                    {
                        _id = _article.Id,
                        _sum = _article.Sum

                    };

            //foreach (var item in query)
            //{
            //    Console.WriteLine($"Товар номер: => {item._id} Сумма к оплате: =>{item._sum}");
            //    Console.WriteLine();
            //}

            foreach (var _article in query.Skip(1 * _sizePage).Take(_sizePage))
            {
                Console.WriteLine($"Товар номер: => {_article._id} Сумма к оплате: =>{_article._sum}");
                Console.WriteLine();
            }

            Console.WriteLine("Введите слово");

            string keywords = Console.ReadLine();
            var queryTag =
                from keyTag in repository
                where Equals(keywords, keyTag.Name) //keywords.Any(tag => keyTag.Name.Contains(tag))
                select keywords;

            foreach (var _keyTag in queryTag)
            {
                Console.WriteLine($"Товар: => {_keyTag}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}