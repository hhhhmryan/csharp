using System;
using System.Collections.Generic;
using System.Text;

namespace lab12
{
    class Person
    {
        public string surname { get; set; }
        public string name { get; set; }
        protected DateTime dob { get; set; }
        protected char gender;
        public char Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (Equals(value, 'ж') || Equals(value, 'м') || Equals(value, 'н'))
                    gender = value;
                else throw new Exception("Ошибка.");
            }
        }

        public Person()
        {
            surname = "";
            name = "";
            dob = new DateTime();
            gender = 'н';
        }

        public Person(string surname, string name, DateTime dob, char gender)
        {
            this.surname = surname;
            this.name = name;
            this.dob = dob;
            this.gender = gender;
        }

        public void input(Person a)
        {
            Console.WriteLine("Введите Фамилию: ");
            a.surname = Console.ReadLine();
            Console.WriteLine("Введите Имя: ");
            a.name = Console.ReadLine();
            Console.WriteLine("Введите Дату рождения: ");
            a.dob = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите Гендер/пол: ");
            a.Gender = char.Parse(Console.ReadLine());
        }

        public void output(Person a)
        {
            Console.WriteLine("Фамилия: " + a.surname);
            Console.WriteLine("Имя: " + a.name);
            Console.WriteLine("Дата рождения: " + a.dob);
            Console.WriteLine("Гендер/пол: " + a.gender);
        }

        public void personsage(Person a, out int age)
        {
            age = DateTime.Now.Year - a.dob.Year;
            if (DateTime.Now.Month < a.dob.Month)
            {
                age -= 1;
            }
            else if (DateTime.Now.Month == a.dob.Month)
            {
                if (DateTime.Now.Day < a.dob.Day)
                {
                    age -= 1;
                }
            }
        }


        






    }
}
