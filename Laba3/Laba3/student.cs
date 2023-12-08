using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Laba3
{
    class student :chelovek
    {
        private string FirstName;
        private string LastName;
        private int Age;
        private string Birthday;
        private double AverageScore;
        private long studencheskiy;
        public long Studencheskiy
        {
            get { return studencheskiy; } set { studencheskiy = value;}
        }
       

        public double averageScore
        {
            get { return AverageScore; }
            set {
                if (value >=2 && value<=5)
                {
                    AverageScore = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("значение среднего балла должно быть от 2 до 5")
                    {

                    };
                }
            }
              

        } 
        
        }
        }
    
    

