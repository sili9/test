using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    namespace DataAccess

    {

        public class StudentsRepository

        {

            private const string FILENAME = @"C:\учеба без ч\oop-labs-2023-II-lab-5-sili9\Laba3\Laba3\studets.txt";

            //public void Save(List<student> stud)

            //{

            //    using (StreamWriter sw = new StreamWriter(FILENAME, true))

            //    {

            //        sw.WriteLine(string.Join(" ", stud.Select(x => $"{x.firstname} {x.lastname} {x.age} {x.averageScore}\n")));

            //    }

                

            //}
            public void Read()
            {
                string[] lines = File.ReadAllLines(FILENAME);
                foreach (var line in lines)
                    Console.WriteLine(line);
            }
        }
    }
}

