using System;
using System.Text;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            // task1 

            Console.WriteLine("Введите строку: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(new char[] { ' ', ',', '.', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Введите длину слова: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Слова заданной и меньше заданной длинны: ");
            foreach (var word in words)
                if (word.Length <= a)
                {
                    Console.WriteLine(word);
                }
            Console.WriteLine();

            // task2
            Console.WriteLine("Слова, начинающиеся с заглавной буквы: ");
            foreach (var word in words)
                if (word[0] == word.ToUpper()[0])
                {
                    Console.WriteLine(word);
                }

            // task3 
            Console.WriteLine("Введите строку: ");
            string task3 = Console.ReadLine();
            string[] words3 = task3.Split(new char[] { ' ', ',', '.', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words3)
            {
                foreach (var nword in words3)
                {
                    if (String.Compare(word, nword) == 0)
                    {
                        task3 = task3.Replace(word, " ");
                    }
                }
            }
            Console.WriteLine(task3);

            // task4
            int schet = 0;
            Console.WriteLine("Введите строку: ");
            string text = Console.ReadLine();
            string[] newtext = text.Split(new char[] { ' ', ',', '.', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Введите слово из строки: ");
            string yourword = Console.ReadLine();
            foreach (var word in newtext)
                if (word == yourword)
                {
                    schet += 1;
                }
            Console.WriteLine(schet);

            // task5 
            int max; string maxname;
            Console.WriteLine("Введите строку: ");
            string task5 = Console.ReadLine();
            string[] newword = task5.Split(new char[] { ' ', ',', '.', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            max = newword[0].Length;
            maxname = newword[0];
            foreach (var word in newword)
                if (word.Length > max)
                {
                    maxname = word;
                }
            Console.WriteLine(maxname);

            // task6
            Console.WriteLine("Введите строку: ");
            string task6 = Console.ReadLine();
            string[] words6 = task6.Split(new char[] { ' ', ',', '.', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words6)
            {
                int c = 0;
                foreach (var nword in words6)
                {

                    if (String.Compare(word, nword) == 0)
                    {
                        c += 1;
                    }
                }
                if (c == 1)
                {
                    Console.WriteLine(word);
                }
                else { c = 0; }
            }

            // task7
            Console.WriteLine("Введите строку: ");
            string task7 = Console.ReadLine();
            Console.WriteLine("Введите количество повторов слова: ");
            int p = int.Parse(Console.ReadLine());
            string[] words7 = task7.Split(new char[] { ' ', ',', '.', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words6)
            {
                int c = 0;
                foreach (var nword in words6)
                {

                    if (String.Compare(word, nword) == 0)
                    {
                        c += 1;
                    }

                }
                if (c >= (p))
                {
                    Console.Write(word + " ");
                }
                else { c = 0; }
            }


            // task8
            Console.WriteLine("Введите строку: ");
            string task8 = Console.ReadLine();
            string[] words8 = task8.Split(new char[] { ' ', ',', '.', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words8.Length - 1; i++)
            {
                if (String.Compare(words8[i], words8[i + 1]) > 0)
                {
                    string a = words8[i];
                    words8[i] = words8[i + 1];
                    words8[i + 1] = a;

                }
            }
            for (int i = 0; i < words8.Length; i++)
            {
                Console.WriteLine(words8[i]);
            }


            // task9
            Console.WriteLine("Введите строку: ");
            string task9 = Console.ReadLine();
            string[] words9 = task9.Split(new char[] { ' ', ',', '.', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words9.Length - 1; i++)
            {
                do
                {

                    if (words9[i].Length > words9[i + 1].Length)
                    {
                        string a = words9[i];
                        words9[i] = words9[i + 1];
                        words9[i + 1] = a;

                    }
                }
                while (words9[0].Length > words9[1].Length && words9[words9.Length - 1].Length < words9[words9.Length - 2].Length);
            }
            for (int i = 0; i < words9.Length; i++)
            {
                Console.WriteLine(words9[i]);
            }

        }
    }
}
