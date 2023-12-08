using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    static class Chelolveki
    {
        public static List<chelovek> All = new List<chelovek>();
        public static void AddPerson(chelovek person)
        {
            All.Add(person);
        }
        public static chelovek SearchChel(long id)
        {
            foreach (chelovek chelovek in All)
            {

                if (chelovek.Personalnumber.Equals(id))
                {

                    Console.WriteLine(chelovek.firstname + " " + chelovek.lastname + " " + chelovek.age + " "  + chelovek.birthday );
                }

            }
            return null;
        }
    }
}
