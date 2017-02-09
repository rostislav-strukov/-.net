using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorkerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter version, what do you use 'TRIAL', 'PRO', 'EXPERT', ");

            string flag = Console.ReadLine().ToLower();

            switch (flag)
            {
                case "trial":
                    DocumentWorker documentWork = new DocumentWorker();
                    documentWork.OpenDocument();
                    documentWork.EditDocument();
                    documentWork.SaveDocument();
                    break;
                case "expert":
                    ExpertDocumentWorker expert = new ExpertDocumentWorker();
                    expert.OpenDocument();
                    expert.EditDocument();
                    expert.SaveDocument();
                    break;
                case "pro":
                    ProDocumentWorker pro = new ProDocumentWorker();
                    pro.OpenDocument();
                    pro.EditDocument();
                    pro.SaveDocument();
                    break;
                default:
                    break;
            }
        }
    }
}
