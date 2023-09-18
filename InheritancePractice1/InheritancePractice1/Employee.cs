using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice1
{
    internal class Employee
    {
        private int id;
        private string name;
        private string lastName;

        public Employee(int id, string name, string lastName) 
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
        }

        public int ID 
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string NAME
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string LASTNAME
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public void showInformatin()
        {
            Console.WriteLine("Employee id = " + id);
            Console.WriteLine("Employee name = " + name);
            Console.WriteLine("Employee lastname = " + lastName);
        }
    }
}
