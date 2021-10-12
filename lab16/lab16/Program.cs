using System;
using System.IO;
using System.Text;

namespace lab16
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //first part
                Console.WriteLine("Task1:");
                StreamReader filein = new StreamReader("input.txt");
                StreamWriter fileout = new StreamWriter(new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.Write));

                string[] text = File.ReadAllLines("input.txt");
                Student[] students = new Student[text.Length];
                for (int i = 0; i < text.Length; i++)
                {
                    string line = text[i];
                    string[] parts = line.Split(',');
                    Student pers = new Student(parts[0], Convert.ToInt32(parts[1]), parts[2], Convert.ToInt32(parts[3]));
                    students[i] = pers;
                }

                Array.Sort(students);
                int schoolnumb = 1;
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i].school == schoolnumb)
                    {
                        string add = students[i].ToString();
                        Console.WriteLine(add);
                        fileout.WriteLine(add);
                    }
                }
                Console.WriteLine();

                filein.Close();
                fileout.Close();

                //second part
                Console.WriteLine("Task2:");
                StreamReader filein1 = new StreamReader("input1.txt");
                StreamWriter fileout1 = new StreamWriter(new FileStream("output1.txt", FileMode.OpenOrCreate, FileAccess.Write));

                string[] listofstudents = File.ReadAllLines("input1.txt");

                ExamStudent[] newstudents = new ExamStudent[listofstudents.Length];
                for (int i = 0; i < listofstudents.Length; i++)
                {
                    string line = listofstudents[i];
                    string[] parts = line.Split(',');
                    ExamStudent student = new ExamStudent(parts[0], Convert.ToInt32(parts[1]), Convert.ToInt32(parts[2]), Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]));
                    newstudents[i] = student;
                }

                Array.Sort(newstudents);

                for (int i = 0; i < newstudents.Length; i++)
                {
                    if (newstudents[i].exam1 != 2 && newstudents[i].exam2 != 2 && newstudents[i].exam3 != 2)
                    {
                        string add = newstudents[i].ToString();
                        Console.WriteLine(add);
                        fileout1.WriteLine(add);
                    }
                }

                filein1.Close();
                fileout1.Close();

            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
