using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_CSS_2
{
    class OnlineResource : Publication
    {
        public override string Title { get; set; }
        public override string Author { get; set; }
        public string Annotation { get; set; }
        public string Link { get; set; }
        public OnlineResource(string name, string autor, string abstr, string lin) : base(name, autor)
        {
            Title = name;
            Author = autor;
            Annotation = abstr;
            Link = lin;
            list.Add(this);
        }

        public override void Print()
        {
            Console.WriteLine($"Title: {Title}\nAuthor's surname: {Author}\nLink: {Link}\nAnnotation: {Annotation}\n");
        }
        public override string Search(string surname)
        {
            if (surname != Author)
            {
                return default;
            }
            return $"Title: {Title}\nAuthor's surname: {Author}\nLink: {Link}\nAnnotation: {Annotation}";
        }

    }
}
