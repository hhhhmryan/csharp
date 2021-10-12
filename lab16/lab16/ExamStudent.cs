using System;
using System.Collections.Generic;
using System.Text;

namespace lab16
{
    class ExamStudent : IComparable
    {

        public string name;
        public int group;
        public int exam1;
        public int Exam1
        {
            get
            {
                return exam1;
            }
            set
            {
                if (value == 2 || value == 3 || value == 4 || value == 5)
                {
                    exam1 = value;
                }
                else
                {
                    throw new Exception("Недопустимое значение оценки.");
                }

            }
        }
        public int exam2;
        public int Exam2
        {
            get
            {
                return exam2;
            }
            set
            {
                if (exam2 == 2 || exam2 == 3 || exam2 == 4 || exam2 == 5)
                {
                    exam2 = value;
                }
                else
                {
                    throw new Exception("Недопустимое значение оценки.");
                }

            }
        }
        public int exam3;
        public int Exam3
        {
            get
            {
                return exam3;
            }
            set
            {
                if (exam3 != 2 || exam3 != 3 || exam3 != 4 || exam3 != 5)
                {
                    exam3 = value;
                }

                else
                {
                    throw new Exception("Недопустимое значение оценки.");
                }
            }
        }

        public ExamStudent(string name, int groupnumber, int firstexamgrade, int secondexamgrade, int thirdexamgrade)
        {
            this.name = name;
            this.group = groupnumber;
            this.Exam1 = firstexamgrade;
            this.exam2 = secondexamgrade;
            this.exam3 = thirdexamgrade;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", name, group, Exam1, exam2, exam3);
        }

        public int CompareTo(object obj)
        {
            return group.CompareTo(((ExamStudent)obj).group);
        }

    }
}
