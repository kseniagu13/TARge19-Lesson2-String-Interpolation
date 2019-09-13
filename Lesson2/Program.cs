using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
      
            string firstName;
            string lastName;
            Console.WriteLine("Enter your first name, please: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your lastname: ");
            lastName = Console.ReadLine();
            //Console.WriteLine("Nice to meet you, " + firstName + " " + lastName + "!");

            //Iam just a comment

            Console.WriteLine("Nice to meet you {0} {1}", firstName, lastName);
            string lemmikVärv;
            Console.WriteLine("What is your favourite colour? ");
            lemmikVärv = Console.ReadLine();
            Console.WriteLine("Hello, Your name is {0} {1}, your favourite colour is {2}. ", firstName, lastName, lemmikVärv);
            string lemmikLaul;
            Console.WriteLine("What is your fav song? ");
            lemmikLaul = Console.ReadLine();
            Console.WriteLine("Hello, Your name is {0} {1}, your fav colour is {2} and you fav song is {3}", firstName, lastName, lemmikVärv, lemmikLaul);

            
        
        


            Console.ReadLine();

        }
    }

}
