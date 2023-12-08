using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    class University
    {
        private static List<student> students = new List<student> ();

        public List<student> stud = students;
        int idd = 1;
        public void AddStudent(student student) 
        {
            if (student != null && ValidateStudent(student))
            {

               students.Add(student);
               
               student.Studencheskiy = idd;
               idd++;


            }
        }
        public bool ValidateStudent(student s)
        {
            return s.firstname != "" && s.lastname != ""
                && s.age > 0
                && s.averageScore >= 2
                && s.averageScore <= 5;
        }
        public student SearchStudent(string searchName, string searchSurname)
        {
            foreach (student student in students)
            {

                if (student.firstname.Equals(searchName) && student.lastname.Equals(searchSurname))
                {

                    Console.WriteLine(student.firstname + " " + student.lastname + " " + student.age + " " + student.averageScore + " " + student.birthday + " " + student.Studencheskiy);

                }

            }
            return null;

        }
        public student SearchStudentById(long id)
        {
            foreach (student student in students)
            {

                if (student.Studencheskiy.Equals(id))
                {
                    Console.WriteLine(student.firstname + " " + student.lastname + " " + student.age + " " +student.averageScore + " " + student.birthday + " " + student.Studencheskiy);
                   return student;
                   

                }
                
            }
            return null;

        }
        public student SearchStudentByPersonalNu(long id)
        {
            foreach (student student in students)
            {

                if (student.Personalnumber.Equals(id))
                {

                    Console.WriteLine(student.firstname + " " + student.lastname + " " + student.age + " " + student.averageScore + " " + student.birthday + " " + student.Studencheskiy);


                }
                Console.WriteLine(student);
            }
            
            return null;

        }

        public bool RemoveStudent(long id)
        {
            student foundStudent = SearchStudentById(id);
            if (foundStudent != null)
            {
                students.Remove(foundStudent);
                return true;;
            }

            return false;
        }
    }
}

  


