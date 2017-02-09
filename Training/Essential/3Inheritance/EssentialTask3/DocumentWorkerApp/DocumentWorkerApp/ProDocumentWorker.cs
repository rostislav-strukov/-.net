using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorkerApp
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document is corrected");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in older format, saving in other formats available in version Expert");
        }
    }
}
