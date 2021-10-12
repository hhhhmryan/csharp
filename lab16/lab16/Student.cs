using System;
using System.Collections.Generic;
using System.Text;

namespace lab16
{
    class Student : IComparable
    {

        public string name;
        public int year;
        public string hometown;
        public int school;

        public Student(string name, int yearofbirth, string hometown, int schoolnumber)
        {
            this.name = name;
            this.year = yearofbirth;
            this.hometown = hometown;
            this.school = schoolnumber;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", name, year, hometown, school);
        }

        public int CompareTo(object obj)
        {
            return year.CompareTo(((Student)obj).year);
        }



    }
}
