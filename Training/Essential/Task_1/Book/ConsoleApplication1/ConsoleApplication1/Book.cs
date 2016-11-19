using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Content;

namespace ConsoleApplication1
{
    class Book
    {
        Author author = null;
        Title title = null;
        Material material = null;

        public void InitializeObject()
        {
            this.author = new Author();
            this.material = new Material();
            this.title = new Title();
        }

        public void ShowAll()
        {
            author.Show();
            title.Show();
            material.Show();
        }

        public string Writer { get { return author.Writer; } set { author.Writer = value; } }
        public string Content { get { return material.Content; } set { material.Content = value;  } }
        public string Title { get { return title.Head; } set { title.Head = value; } }
    }
}
