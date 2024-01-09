using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_CSS_2
{
    abstract class Publication
    {
        public virtual string Title { get; set; }
        public virtual string Author { get; set; }
        public virtual int Year { get; set; }
        public virtual string Publisher { get; set; }
        public List<Publication> list;
        public Publication(string title, string autor)
        {
            Title = title;
            Author = autor;
            list = new List<Publication>();
        }

        public abstract void Print();
        public abstract string Search(string surname);

    }
}
