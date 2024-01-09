using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_CSS_2
{
    class Book : Publication
    {
        public override string Title { get; set; }
        public override string Author { get; set; }
        public override int Year { get; set; }
        public override string Publisher { get; set; }
        public Book(string name, string autor, int year, string eGroup) : base(name, autor)
        {
            Title = name;
            Author = autor;
            Year = year;
            Publisher = eGroup;
            list.Add(this);
        }
        public override void Print()
        {
            Console.WriteLine($"Title: {Title}\nAuthor's surname: {Author}\nYear: {Year}\nPublisher: {Publisher}\n");
        }
        public override string Search(string surname)
        {
            if (surname != Author)
            {
                return default;
            }
            return $"Title: {Title}\nAuthor's surname: {Author}\nYear: {Year}\nPublisher: {Publisher}";
        }

    }
}
