using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {

            //c;)Group - un addStudent() ve RemoveStudent() metodlari yazilmalidir

            Group group1 = new Group();
            group1.GroupName = "Group name is: Bp201";
            group1.MaxStuCount = $"Max student count:{16}";

            Student stu1 = new Student();
            stu1.Id = 102345;
            stu1.Name = "Fatime";
            stu1.Surename = "Bayramova";
            stu1.Speciality = "Computer science";
            group1.addStudent();
            //group1.RemoveStudent(2);
        }
    }

    class Student
    {
        public int _id;
        public string name;
        public string surename;
        public string speciality;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                Console.WriteLine(value);
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                Console.WriteLine(value);
            }
        }

        public string Surename
        {
            get
            {
                return surename;
            }
            set
            {
                Console.WriteLine(value);
            }
        }

        public string Speciality
        {
            get
            {
                return speciality;
            }
            set
            {
                Console.WriteLine(value);
            }
        }
    }

    class Group : Student
    {
        public string _groupName;
        public string _maxStuCount;
        public Student[] _stuArray;

        public string GroupName
        {
            get
            {
                return _groupName;
            }
            set
            {
                Console.WriteLine(value);
            }
        }

        public string MaxStuCount
        {
            get
            {
                return _maxStuCount;
            }
            set
            {
                Console.WriteLine(value);
            }
        }
        public Student[] StuArray
        {
            get
            {
                return _stuArray;
            }
            set
            {
                Console.WriteLine(value);
            }

        }

        public void addStudent()
        {
            var StuArray = new Student[16];
            StuArray[1] = new Student();
            StuArray[1].Id = 102030;
            StuArray[1].Name = "Gunay";
            StuArray[1].Surename = "Abbasova";
            StuArray[1].Speciality = "Computer science";

            
            StuArray[2] = new Student();
            StuArray[2].Id = 135030;
            StuArray[2].Name = "Mehemmed";
            StuArray[2].Surename = "Ceferzade";
            StuArray[2].Speciality = "Computer science";


            Console.WriteLine($"{StuArray[0]}  New Student added sucsessfully!");

        }

        public void RemoveStudent(int i)
        {
            //var StuArray = new Student[16];
            //StuArray[i].Id = 0;
            //StuArray[i].Name = "Deleted";
            //StuArray[2].Surename = "Deleted";
            //StuArray[2].Speciality = "Deleted";a 


        }
    }
}
