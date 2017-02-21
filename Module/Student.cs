using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    class Student : Person
    {
        private static int enrolledStudents;

        public static int EnrolledStudents {
            get { return enrolledStudents; }
        }

        public Student(string first, string last, DateTime date) : base(first, last, date)
        {
            enrolledStudents++;
        }

        public override void PrepareForClass()
        {
            Console.WriteLine("Review reading assignments and do homework.");
        }

        public void TakeTest()
        {
            Console.WriteLine("Take test (Yikes).");
        }

        public void GoToLibrary()
        {
            Console.WriteLine("Go to the library.");
        }

        public override void GoAboutMyDay()
        {
            PrintBio();
            PrepareForClass();
            TakeTest();
            GoToLibrary();
        }

        private Stack grades = new Stack();

        public void AddGrade(int grade)
        {
            grades.Push(grade);
        }
    }
}
