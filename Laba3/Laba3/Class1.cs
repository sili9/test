using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    class chelovek
    {
            private string FirstName;
            private string LastName;
            private int Age;
            private string Birthday;
        private static long counter = 1;
        private long personalnumber;

        public long Personalnumber
        {

            get {
                personalnumber = counter++;
                    return personalnumber; }
        }
        public string firstname
            {
                get { return FirstName; }
                set
                {
                    if (value != null)
                    {
                        FirstName = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("введите имя")
                        {

                        };
                    }
                }


            }
            public string lastname
            {
                get { return LastName; }
                set
                {
                    if (value != null)
                    {
                        LastName = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("введите фамили")
                        {

                        };
                    }
                }
            }
            public int age
            {
                get { return Age; }
                set
                {
                    if (value > 0)
                    {
                        Age = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("возраст не может быть отрицательным")
                        {

                        };
                    }
                }
            }
            public string birthday
            {
            get { return Birthday; }
            set { Birthday = value; }
            }
            public chelovek()
        {
            Chelolveki.AddPerson(this);
        }
           

        }

    }
