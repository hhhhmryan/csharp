using System;

namespace lab13task3
{
    class Program
    {
        static void Main(string[] args)
        {

            Edition[] eds = new Edition[4];
            eds[0] = new Book("NameOfTheBook", "Author'sSurname", DateTime.Now, "NewPublushingHouse");
            eds[1] = new Article("NameOfTheArticle", "Antony", "NewMagazine", 36, DateTime.Now);
            eds[2] = new EResource("NameOfTheResource", "Author'sSurname", "newresource.com", "Annotation");
            eds[3] = new Book("NameOfTheSecondBook", "SecondAuthor'sSurname", DateTime.Now, "NewPublushingHouseForBooks");

            for (int i = 0; i < eds.Length; i++)
            {
                eds[i].Info();
                Console.WriteLine();
            }

            Console.WriteLine("Введите фамилию автора для поиска: ");
            string findauthor = new string(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < eds.Length; i++)
            {
                if (eds[i].author == findauthor)
                {
                    Console.WriteLine("Издание принадлежит выбранному автору. Вот найденная о нем информация: ");
                    eds[i].Info();
                }
            }
        }
    }
}
