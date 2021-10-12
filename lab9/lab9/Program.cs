using System;
using System.Text.RegularExpressions;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            string line = "Дать знать, Если что-то не пОлучится";
            Console.WriteLine("Введите слово для проверки: ");
            string word = Console.ReadLine();
            if (Regex.IsMatch(line, word))
            {
                Console.WriteLine("Ваше слово имеется в выражении.");
            }
            else Console.WriteLine("Вашего слова нет в выражени.");
            Console.WriteLine();

            //Task2
            Console.WriteLine("Задайте длину слова: ");
            int length = int.Parse(Console.ReadLine());
            string pattern = @"\b(\w{" + length + @"})\b";
            foreach (Match item in Regex.Matches(line, pattern))
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine();

            //Task3 
            string newpatt = (@"\b[A-ZА-Я]\w*");
            foreach (Match newmatch in Regex.Matches(line.ToString(), newpatt))
            {
                Console.WriteLine(newmatch.Value);
            }
            Console.WriteLine();

            //Task4
            string taskfour = "Why! :dogs?? are! so,,,, cute....";
            string anotherpatt = (@"[,.!?;:]");
            string replacement = "";
            Console.WriteLine(Regex.Replace(taskfour, anotherpatt, replacement));
            Console.WriteLine();

            //Task5
            string taskfive = "Привет my name is Кот, я was born в Казани. Мне ten (10) years с рождения.";
            string pattern5 = (@"\b[A-Za-z]\w*");
            string myrep = "...";
            Console.WriteLine(Regex.Replace(taskfive, pattern5, myrep));

            //Task6 
            double sum = 0;
            string tasksix = "good 4 / ? } 56 8 2,5 7 10 nice 0";
            string pat = (@"[+-]?\d+\,?\d*");
            foreach (Match summ in Regex.Matches(tasksix, pat))
            {
                sum = sum + double.Parse(summ.Value);
            }
            Console.WriteLine(sum);

            //Task7
            string taskseven = "15.11.1890 37.09.2020 11.02.1999 11.09.2017 17.09.2018 12.05.2001 04.05.2020 27.10.1996 26.03.1990 01.07.1995 31.05.2020";
            string thisyear = (@"(0[1-9]|[12][0-9]|3[01])\.(0[1-9]|1[012])\.2020");

            foreach (Match info in Regex.Matches(taskseven, thisyear))
            {
                Console.WriteLine(info.Value);
            }
            Console.WriteLine();

            //Task8
            string taskeight = "15.11.1890 37.09.2020 11.02.1999 11.09.2017 17.09.2018 12.05.2001 04.05.2020 27.10.1996 26.03.1990 01.07.1995 31.05.2020";
            Console.WriteLine(taskeight);
            Console.WriteLine();
            string date = (@"(0[1-9]|[12][0-9]|3[01])\.(0[1-9]|1[12])\.(19[0-9]{2}|2020|200[0-9])");

            foreach (Match thisday in Regex.Matches(taskeight, date))
            {

                Console.WriteLine("Дата: " + thisday.Value);

                string[] parts = thisday.Value.Split('.');
                int dd = int.Parse(parts[0]);
                int mm = int.Parse(parts[1]);
                int yy = int.Parse(parts[2]);

                if (dd != 1)
                {
                    dd = dd - 1;
                }
                else if (dd == 1)
                {
                    if (mm != 1)
                    {
                        switch (mm)
                        {
                            case 2:
                                mm = mm - 1;
                                dd = 31;
                                break;
                            case 3:
                                mm = mm - 1;
                                dd = 28;
                                break;
                            case 4:
                                mm = mm - 1;
                                dd = 31;
                                break;
                            case 5:
                                mm = mm - 1;
                                dd = 30;
                                break;
                            case 6:
                                mm = mm - 1;
                                dd = 31;
                                break;
                            case 7:
                                mm = mm - 1;
                                dd = 30;
                                break;
                            case 8:
                                mm = mm - 1;
                                dd = 31;
                                break;
                            case 9:
                                mm = mm - 1;
                                dd = 31;
                                break;
                            case 10:
                                mm = mm - 1;
                                dd = 30;
                                break;
                            case 11:
                                mm = mm - 1;
                                dd = 31;
                                break;
                            case 12:
                                mm = mm - 1;
                                dd = 30;
                                break;
                        }
                    }
                    else if (mm == 1)
                    {
                        dd = 31;
                        mm = 12;
                        yy = yy - 1;
                    }
                }
                string dd1 = dd.ToString();
                string mm1 = mm.ToString();
                string yy1 = yy.ToString();
                string dot = ".";
                string newdate = dd1 + dot + mm1 + dot + yy1;

                Console.WriteLine("Дата прошлого дня: " + dd + "." + mm + "." + yy);


                taskeight = Regex.Replace(taskeight, date, newdate);
                Console.WriteLine(taskeight);
                Console.WriteLine();
            }
            Console.WriteLine(taskeight);




        }
    }
}
