using System;
using System.Collections.Generic;
using System.Text;

namespace lab13task3
{
    class EResource : Edition
    {

        string link;
        string annotation;

        public EResource(string name, string author, string link, string annotation)
        {
            this.name = name;
            this.author = author;
            this.link = link;
            this.annotation = annotation;
        }

        public override void Info()
        {
            Console.WriteLine("Тип Издания: Электронный ресурс.");
            Console.WriteLine("Название ресурса: " + name);
            Console.WriteLine("Фамилия автора: " + author);
            Console.WriteLine("Ссылка: " + link);
            Console.WriteLine("Аннотация: " + annotation);
        }

    }
}
