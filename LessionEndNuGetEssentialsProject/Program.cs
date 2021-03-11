using System;

namespace LessionEndNuGetEssentialsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter Student Details\n");
            Student[] studentArray = new Student[3];
            StudentProgram.InputStudent(studentArray);

            Console.WriteLine("\nEnter teacher Details\n");
            Teacher[] teacherArray = new Teacher[2];
            TeacherProgram.InputTeacher(teacherArray);

            Console.WriteLine("\nEnter subject Details\n");
            Subject[] subjectArray = new Subject[2];
            SubjectProgram.InputSubject(subjectArray);

            Console.WriteLine(StudentProgram.PrintStudent(studentArray));
            Console.WriteLine(SubjectProgram.PrintSubject(subjectArray));
            Console.WriteLine(TeacherProgram.PrintTeacher(teacherArray));
        }
    }
}
