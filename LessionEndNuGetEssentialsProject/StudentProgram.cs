using System;
using System.Collections.Generic;
using System.Text;

namespace LessionEndNuGetEssentialsProject
{
    class StudentProgram
    {
        public static void InputStudent(Student[] students)
        {
            Console.WriteLine("\nEnter Student Details");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"\nEnter Student {i + 1} Name");
                students[i].Name = Console.ReadLine();
                Console.WriteLine($"Enter Student {i + 1} Class and Section");
                students[i].ClassAndSection = Console.ReadLine();
            }
        }

        public static string PrintStudent(Student[] students)
        {
            string studentDetails = "";
            foreach (Student student in students)
            {
                studentDetails += "Name: " + student.Name + ", Class and Section: " + student.ClassAndSection + "\n";
            }
            return studentDetails;
        }
    }

    struct Student
    {
        public string Name { get; set; }
        public string ClassAndSection { get; set; }
    }
}
