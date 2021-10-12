using System;
using System.Collections.Generic;
using System.Text;

namespace lab13task3
{
    class Article : Edition
    {

        string magazine;
        int number;
        DateTime yearofpub;

        public Article(string name, string author, string magazine, int number, DateTime yearofpub)
        {
            this.name = name;
            this.author = author;
            this.magazine = magazine;
            this.number = number;
            this.yearofpub = yearofpub;
        }

        public override void Info()
        {
            Console.WriteLine("Тип Издания: Статья.");
            Console.WriteLine("Название статьи: " + name);
            Console.WriteLine("Фамилия автора: " + author);
            Console.WriteLine("Название журнала " + magazine);
            Console.WriteLine("Номер журнала: " + number);
            Console.WriteLine("Год издания: " + yearofpub);
        }

    }
}
