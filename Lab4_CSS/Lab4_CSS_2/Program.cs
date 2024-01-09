using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_CSS_2
{
    internal class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.GetEncoding(1251);
            List<Publication> catalog = new List<Publication>();
            OnlineResource onlineBook1 = new OnlineResource("Місто", "Підмогильний", "Необхідно", "https://www.ukrlib.com.ua/books/printit.php?tid=76");
            Article magazine = new Article("С++ найкраща мова", "Український програміст", "Мамонов", 2021, 12);
            Book book1 = new Book("Відьмак. Останнє Бажання", "Сапковський", 1993, "Книжковий Клуб. Клуб Сімейного Дозвілля");
            OnlineResource onlineBook2 = new OnlineResource("Кайдашева сім'я", "Нечуй-Левицький", "Україньска класика", "https://www.ukrlib.com.ua/books/printit.php?tid=907");
            Article news = new Article("Слобідський край", "Таланти Слобожанщини", "Тютюнник", 2022, 1);
            Book book2 = new Book("Відьмак. Вежа Ластівки", "Сапковський", 1997, "Книжковий Клуб. Клуб Сімейного Дозвілля");
            catalog.Add(onlineBook1);
            catalog.Add(magazine);
            catalog.Add(book1);
            catalog.Add(onlineBook2);
            catalog.Add(news);
            catalog.Add(book2);
            Console.WriteLine("Catalog:");
            for (int i = 0; i < catalog.Count; i++)
                catalog[i].Print();
            Console.Write("If you want to know more about a publication, enter the last name of its author: ");
            string surname = Console.ReadLine();
            for (int i = 0; i < catalog.Count; i++)
                Console.WriteLine(catalog[i].Search($"{surname}"));

        }

    }
}
