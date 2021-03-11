using System;
using System.Collections.Generic;
using System.Text;

namespace LessionEndNuGetEssentialsProject
{
    class TeacherProgram
    {
        public static void InputTeacher(Teacher[] teachers)
        {
            Console.WriteLine("\nEnter teacher Details");
            for (int i = 0; i < teachers.Length; i++)
            {
                Console.WriteLine($"\nEnter Teacher {i + 1} Name");
                teachers[i].Name = Console.ReadLine();
                Console.WriteLine($"Enter Teacher {i + 1} Class and Section");
                teachers[i].ClassAndSection = Console.ReadLine();
            }
        }

        public static string PrintTeacher(Teacher[] teachers)
        {
            string teacherDetails = "";
            foreach (Teacher teacher in teachers)
            {
                teacherDetails += "Name: " + teacher.Name + ", Class and Section: " + teacher.ClassAndSection + "\n";
            }
            return teacherDetails;
        }
    }

    struct Teacher
    {
        public string Name { get; set; }
        public string ClassAndSection { get; set; }
    }
}
