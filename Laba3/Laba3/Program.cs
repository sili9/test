using Laba3;
using Laba3.DataAccess;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        University universit = new University();
        student chelovek1 = new student();
        StudentsRepository studentsRepository = new StudentsRepository();
        chelovek1.firstname = "Иван";
        chelovek1.lastname = "Крылов";
        chelovek1.age = 19;
        chelovek1.averageScore = 4.9;
        chelovek1.birthday = "02.07.2004";
        student chelovek2 = new student();
        chelovek2.firstname = "Эрика";
        chelovek2.lastname = "Сибирцева";
        chelovek2.birthday = "16.06.2004";
        chelovek2.age = 19;
        chelovek2.averageScore = 5;
        universit.AddStudent(chelovek1);
        universit.AddStudent(chelovek2);
        universit.RemoveStudent(1);
        Chelolveki.SearchChel(1);
        universit.SearchStudentById(1);



    }
}
   