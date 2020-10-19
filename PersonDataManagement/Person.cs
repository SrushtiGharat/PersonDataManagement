using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDataManagement
{
    class Person
    {
        public string SSN;
        public string Name;
        public string Address;
        public int Age;

        public Person()
        {
            SSN = "";
            Name = "";
            Address = "";
            Age = 0;
        }
        public Person(string SSN, string Name, string Address, int Age)
        {
            this.SSN = SSN;
            this.Name = Name;
            this.Address = Address;
            this.Age = Age;
        }
    }
}
