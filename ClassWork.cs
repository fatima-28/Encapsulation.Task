using System;

namespace homeTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("Fatime", "Bayramova", "Tk75", false, 80);
            stu1.NameAndSurename();
            stu1.AllInfo();
            stu1.ExamPremission(90);
        }
    }

    class Student
    {
        public string Name;
        public string Surename;
        public string Group;
        public int Point;
        public bool IsGraduate;

        public Student()
        {
            Console.WriteLine("Ad, Soyad, Group, Point, Is Graduate");
        }

        public Student(string name, string surename, string group, bool isGraduate, int point)
        {
            Name = name;
            Surename = surename;
            Group = group;
            IsGraduate = isGraduate;
            Point = point;
        }

        public void NameAndSurename()
        {
            Console.WriteLine($"Ad: {Name}, Soyad: {Surename}");
        }

        public void AllInfo()
        {
            Console.WriteLine($"Ad: {Name}, Soyad: {Surename} Group: {Group} Point:{Point}");


            if (IsGraduate)
            {

                Console.WriteLine("Telebe mezun olub");
            }
            else
            {

                Console.WriteLine("Telebe hele mezun olmayib");
            }

        }
        public void ExamPremission(int point)
        {
            if (point >= 80)
            {
                Console.WriteLine("telebe imtahana gire biler");
            }
            else
            {
                Console.WriteLine("Telebe imtahana gire bilemz");
            }
        }

    }
}
