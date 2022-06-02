using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance
{
    public  class person
    {
        //properties
        public string Name { get; set; }
        public int Age { get; set; }

        public void GetNameAndAge()
        {
            Console.WriteLine("The Person Has Name: {0} and Age: {1}", Name, Age);
        }
    }
}
