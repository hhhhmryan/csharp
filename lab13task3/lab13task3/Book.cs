using System;
using System.Collections.Generic;
using System.Text;

namespace lab13task3
{
    class Book : Edition
    {

        DateTime yearofpub;
        string pubhouse;

        public Book(string name, string author, DateTime yearofpub, string pubhouse)
        {
            this.name = name;
            this.author = author;
            this.yearofpub = yearofpub;
            this.pubhouse = pubhouse;
        }

        public override void Info()
        {
            Console.WriteLine("Тип Издания: Книга.");
            Console.WriteLine("Название книги: " + name);
            Console.WriteLine("Фамилия автора: " + author);
            Console.WriteLine("Год издания: " + yearofpub);
            Console.WriteLine("Издательство: " + pubhouse);
        }

    }
}
