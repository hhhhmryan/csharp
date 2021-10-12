using System;

namespace lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lab 12 task2

            //part1 

            Person x = new Person("Иванов", "Иван", DateTime.Today, 'м');
            Person y = new Person();

            y.input(y);
            y.output(y);
            int age;
            y.personsage(y, out age);
            Console.WriteLine(age);

            Console.WriteLine("Введите количество человек в списке: ");
            Console.WriteLine("n=");
            int m = int.Parse(Console.ReadLine());
            Person[] b = new Person[m];
            for (int i = 1; i < b.Length; i++)
            {
                Person z = new Person();
                z.input(z);
                b[i] = z;
            }

            for (int i = 1; i < b.Length; i++)
            {
                int persage;
                string fio = b[i].surname + " " + b[i].name[0] + ".";
                b[i].personsage(b[i], out persage);
                Console.WriteLine("Человек: " + fio);
                Console.WriteLine("Возраст: " + persage);
                Console.WriteLine("Пол: " + b[i].Gender);
            }



            //part2


            Console.WriteLine("Worker Info: ");
            Worker Matt = new Worker("Edwards", "Mattew", DateTime.Today, 'м', 10000, 12, 11);
            Matt.outputW(Matt);
            Matt.goodworker(Matt);
            double income = Matt.income(Matt);
            Console.WriteLine("Mattew's income: " + income);
            double tax = Matt.incometax(Matt);
            Console.WriteLine("Mattew's income tax: " + tax);
            double wage = Matt.wage(Matt);
            Console.WriteLine("Mattew's wage: " + wage);

            Console.WriteLine("Тестирование класса(задание а): ");
            Console.WriteLine();
            DateTime dateIvan = new DateTime(1995, 01, 12);
            Worker test = new Worker("Петров", "Иван", dateIvan, 'м', 40000, 15, 2);
            Worker test2 = new Worker();
            test2.inputW(test2);

            double a1 = test.income(test);
            double a2 = test2.income(test2);
            double b1 = test.wage(test);
            double b2 = test2.wage(test2);
            Console.WriteLine("Сумма, заработанная первым рабочим(Иваном): " + a1);
            Console.WriteLine("Первый рабочий(Иван) получил на руки сумму: " + a2);
            Console.WriteLine("Сумма, заработанная вторым рабочим: " + b1);
            Console.WriteLine("Второй рабочий получил на руки сумму: " + b2);



            Console.WriteLine("Задание б: ");
            int n = 5;
            Worker[] a = new Worker[n];
            for (int i = 1; i < a.Length; i++)
            {
                Worker z = new Worker();
                z.inputW(z);
                z.goodworker(z);
                a[i] = z;
            }

            double wholetax = 0;
            for (int i = 1; i < a.Length; i++)
            {
                wholetax += a[i].incometax(a[i]);
            }

            double max = a[0].income(a[0]); string maxworker = a[0].surname;
            for (int i = 2; i < a.Length; i++)
            {
                if (a[i].income(a[i]) > max)
                {
                    max = a[i].income(a[i]);
                    maxworker = a[i].surname;
                }
            }

            Console.WriteLine("Общая налоговая сумма: " + wholetax);
            Console.WriteLine("Работник, заработавший больше всех: " + maxworker);


            //part3


            HourWorker Jake = new HourWorker();
            Jake.inputHW(Jake);
            Jake.outputHW(Jake);
            Console.WriteLine();

            Jake.goodworker(Jake);
            double income1 = Jake.income(Jake);
            Console.WriteLine("Jake's income: " + income1);
            double tax1 = Jake.incometax(Jake);
            Console.WriteLine("Jake's income tax: " + tax1);
            double wage1 = Jake.wage(Jake);
            Console.WriteLine("Jake's wage: " + wage1);
















        }
    }
}
