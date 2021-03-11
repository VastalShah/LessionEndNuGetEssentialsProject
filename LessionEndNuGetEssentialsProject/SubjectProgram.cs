using System;
using System.Collections.Generic;
using System.Text;

namespace LessionEndNuGetEssentialsProject
{
    class SubjectProgram
    {
        public static void InputSubject(Subject[] subjects)
        {
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine($"\nEnter Subject {i + 1} Name:");
                subjects[i].Name = Console.ReadLine();
                Console.WriteLine($"Enter Subject {i + 1} Code:");
                subjects[i].Code = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static string PrintSubject(Subject[] subjects)
        {
            string subjectDetails = "";
            foreach (Subject subject in subjects)
            {
                subjectDetails += "Name: " + subject.Name + ", Class and Section: " + subject.Code + "\n";
            }
            return subjectDetails;
        }
    }

    struct Subject
    {
        public string Name { get; set; }
        public int Code { get; set; }
    }
}
