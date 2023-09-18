using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice1
{
    internal class Programmers : Employee
    {
        string languages;
        public string LANGUAGES
        {
            get { return languages; }
            set { languages = value; }
        }
        public Programmers(int id, string name, string lastName, string languages) : base(id, name, lastName)
        {
            this.languages = languages;
        }

        public void format(string OS)
        {
            Console.WriteLine(NAME + " is formatting " + OS);
        }
    }
}
