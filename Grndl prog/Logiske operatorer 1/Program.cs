using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;

using System.Text;
using System.Xml.Linq;

namespace and_operator
{
    class Program
    {
        static void Main(string[] args)
        {

            string name, password;

            name = "Steven";
            password = "Steven123";

            // evaluating both expresson and returns true if              all are true.

            if (name == "Steven" && password == "Steven123")
            {
                Console.WriteLine("login succesful");
            }
            else
            {
                Console.WriteLine("Unauthorised access");
            }
            Console.ReadLine();
        }
    }
}