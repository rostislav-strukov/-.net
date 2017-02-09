using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorkerApp
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Document opened");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("You are have ability edit document only version Pro");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Saving only version Pro");
        }
    }
}
