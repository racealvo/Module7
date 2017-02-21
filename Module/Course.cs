using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    class Course
    {
        private ArrayList students = new ArrayList();
        private Teacher[] teachers = new Teacher[3];

        //// Course Info
        public string CourseName { get; private set; }
        public int Credits { get; private set; }
        public int Duration { get; private set; }

        public Course(string courseName, int credits, int duration)
        {
            CourseName = courseName;
            Credits = credits;
            Duration = duration;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public bool AddTeacher(Teacher teacher)
        {
            bool bTeacherAdded = false;

            // Add the teacher if there is room
            for (int i = 0; i < teachers.Length; i++)
            {
                if (teachers[i] == null)
                {
                    teachers[i] = teacher;
                    bTeacherAdded = true;
                    break;
                }
            }

            if (!bTeacherAdded)
            {
                Console.WriteLine("Unable to add teacher {0} {1}.  Course is full.", teacher.FirstName, teacher.LastName);
            }
            return bTeacherAdded;
        }

        /// <summary>
        /// Get the number of students enrolled in the course.
        /// </summary>
        public int EnrolledStudentCount {
            get {
                int count = 0;
                foreach(var student in students)
                {
                    if (student != null)
                        count++;
                }
                return count;
            }
        }

        /// <summary>
        /// List the students enrolled in the course
        /// </summary>
        public void ListStudents()
        {
            foreach(Student student in students)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
