using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP02.Encapsulation
{
    internal struct Person
    {
        #region Attributes
        private string name;
        private int age;
        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
            set
            {
                if (value is not null && value.Length != 0)
                    name = value;
                else
                    Console.WriteLine("Invalid Name.");
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 12)
                    age = value;
                else
                    Console.WriteLine("invalid Age");
            }
        }
        #endregion

        #region Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        #endregion
    }
}
