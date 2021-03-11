using System;

namespace LessionEndNuGetEssentialsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many student records you want to store?");
            int studentLength = Convert.ToInt32(Console.ReadLine());
            Student[] studentArray = new Student[studentLength];
            StudentProgram.InputStudent(studentArray);

            Console.WriteLine("\nHow many teacher records you want to store?");
            int teacherLength = Convert.ToInt32(Console.ReadLine());
            Teacher[] teacherArray = new Teacher[teacherLength];
            TeacherProgram.InputTeacher(teacherArray);

            Console.WriteLine("\nHow many subject records you want to store?");
            int subjectLength = Convert.ToInt32(Console.ReadLine());
            Subject[] subjectArray = new Subject[subjectLength];
            SubjectProgram.InputSubject(subjectArray);

            Console.WriteLine("\nStudent Details:");
            Console.WriteLine(StudentProgram.PrintStudent(studentArray));
            

            Console.WriteLine("\nTeacher Details:");
            Console.WriteLine(TeacherProgram.PrintTeacher(teacherArray));

            Console.WriteLine("\nSubject Details:");
            Console.WriteLine(SubjectProgram.PrintSubject(subjectArray));
        }
    }
}
