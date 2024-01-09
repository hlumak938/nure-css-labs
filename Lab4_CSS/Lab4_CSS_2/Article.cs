using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_CSS_2
{
    class Article : Publication
    {
        public override string Title { get; set; }
        public string ArticleName { get; set; }
        public override string Author { get; set; }
        public override int Year { get; set; }
        public int Number { get; set; }
        public Article(string name, string autor, string articName, int year, int num) : base(name, autor)
        {
            Title = name;
            ArticleName = articName;
            Author = autor;
            Year = year;
            Number = num;
            list.Add(this);
        }
        public override void Print()
        {
            Console.WriteLine($"Title: {Title}\nArticle name: {ArticleName}\nAuthor's surname: {Author}\nYear: {Year}\nNumber: {Number}\n");
        }
        public override string Search(string surname)
        {
            if (surname != Author)
            {
                return default;
            }
            return $"Title: {Title}\nArticle name: {ArticleName}\nAuthor's surname: {Author}\nYear: {Year}\nNumber: {Number}";
        }

    }
}
