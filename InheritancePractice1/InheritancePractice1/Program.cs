using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            while(true)
            {
                Console.WriteLine("Welcome to employee app");

                Console.WriteLine("1 => for programmer");
                Console.WriteLine("2 => for supervisor");
                Console.WriteLine("q => for exit");

                string option = Console.ReadLine();
                if (option == "q")
                {
                    Console.WriteLine("Exitlin the program...");
                    break;
                }else if (option == "1") 
                {
                    Programmers programmers = new Programmers(1, "Özay", "Yıldız", "C#");
                    while(true) 
                    {
                        Console.WriteLine("1 => for programmer information");
                        Console.WriteLine("2 => for format");
                        Console.WriteLine("q => for exit");
                        string programmerOption = Console.ReadLine();
                        if (programmerOption == "q")
                        {
                            Console.WriteLine("Exitlin the programmer option...");
                            break;
                        }else if(programmerOption == "1")
                        {
                            programmers.showInformatin();
                        }else if(programmerOption == "2")
                        {
                            programmers.format("Windows 11");
                        }
                    }
                }else if(option == "2")
                {
                    Supervisors supervisors = new Supervisors(1, "Merve", "Erden", 10);               
                    while (true)
                    {
                        Console.WriteLine("1 => for supervisor information");
                        Console.WriteLine("2 => for raise");
                        Console.WriteLine("q => for exit");
                        string programmerOption = Console.ReadLine();
                        if (programmerOption == "q")
                        {
                            Console.WriteLine("Exitlin the supervisor option...");
                            break;
                        }
                        else if (programmerOption == "1")
                        {
                            supervisors.raise(1000);
                        }
                        else if (programmerOption == "2")
                        {
                            supervisors.showInformatin();
                        }
                    }
                }
            }
            
            Console.ReadLine();
        }
    }
}
