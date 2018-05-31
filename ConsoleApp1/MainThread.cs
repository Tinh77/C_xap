using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class MainThread
    {
        private static List<Student> list = new List<Student>();

        public static void Main(string[] args)
        {
            GenerateMenu();
        }

        private static void SearchByName()
        {
            Console.WriteLine("Please enter name to seach: ");
            var searchKey = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                Student student = list[i];
                if (student.Name == searchKey)
                {
                    Console.WriteLine("Found: ");
                    Console.WriteLine(student.RollNumber + " - " + student.Name);
                }
            }
        }

        private static void AddStudent()
        {
            var student = new Student();
            Console.WriteLine("Please enter student rollNumber:");
            student.RollNumber = Console.ReadLine();
            Console.WriteLine("Please enter student name:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Please enter student email:");
            student.Email = Console.ReadLine();
            Console.WriteLine("Please enter student phone:");
            student.Phone = Console.ReadLine();
            list.Add(student);
        }

        private static void DisplayStudent()
        {
            foreach (var student in list)
            {
                Console.WriteLine(student.Name);
            }
        }

        private static void GenerateMenu()
        {
            while (true)
            {
                Console.WriteLine("============Student Menu===========");
                Console.WriteLine("1. Nhập sinh viên.");
                Console.WriteLine("2. In sinh viên ra List");
                Console.WriteLine("3. Tìm sinh viên theo tên.");
                Console.WriteLine("4. Thoát.");
                Console.WriteLine("====================================");
                Console.WriteLine("Mời bạn nhập số: ");
                var choose = Int32.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        DisplayStudent();
                        break;
                    case 3:
                        SearchByName();
                        break;
                    case 4:
                        Environment.Exit(1);
                        break;
                }
            }
        }
    }
}