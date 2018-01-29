using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Student
    {
        string name;
        string lname;
        public double gpa;

        public Student(string name, string lname, double gpa)
        {
            this.name = name;
            this.lname = lname;
            this.gpa = gpa;
        }
        public void ReadInfo()
        {
            name = Console.ReadLine();
            lname = Console.ReadLine();
            gpa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        public void PrintInfo()
        {
            Console.WriteLine(lname + " " + name + " " + gpa);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> l = new List<Student>();
            Random r = new Random();
            int n = r.Next(10, 15);
            for (int i = 0; i < n; ++i)
            {
                double gpa = r.Next(0, 4) + r.NextDouble();
                Student s = new Student("Eldar" + i, lname: $"Tastanov{i}", gpa: gpa);
                l.Add(s);
            }
            for (int i = 0; i < n - 1; ++i)
            {
                for (int j = i + 1; j < n; ++j)
                {
                    if (l[i].gpa > l[j].gpa)
                    {
                        Student t = l[i];
                        l[i] = l[j];
                        l[j] = t;
                    }
                }
            }
            for (int i = 0; i < n; ++i)
            {
                l[i].PrintInfo();
            }
            Console.ReadKey();
        }
    }
}
      

    

