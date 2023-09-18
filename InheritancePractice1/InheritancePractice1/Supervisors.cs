using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice1
{
    internal class Supervisors : Employee
    {
        private int numberofResponsiblePeople;
        public int MyProperty 
        {
            get 
            {
                return numberofResponsiblePeople;
            }
            set
            {
                numberofResponsiblePeople = value;
            } 
        }
        public Supervisors(int id, string name, string lastName, int numberofResponsiblePeople) : base(id, name, lastName)
        {
            this.numberofResponsiblePeople = numberofResponsiblePeople;
        }

        public void raise(int raise)
        {
            Console.WriteLine("Raise amount for " + NAME + " is " + raise);
        }
    }
}
