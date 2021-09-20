using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables");

            int score; // create an interger variable named, "score"
            score = 0; // assing 0 to score

            Console.WriteLine(score); // accessing a variable
            Console.WriteLine("score"); // NOT accessing a variable

            score = score + 100; //stomped an enemy for 100 points
            Console.WriteLine(score); // accessing a variable
            score = score + 100; //stomped an enemy for 100 points
            Console.WriteLine(score); // accessing a variable
            score = score + 100; //stomped an enemy for 100 points
            Console.WriteLine(score); // accessing a variable
            score = score + 100; //stomped an enemy for 100 points
            Console.WriteLine(score); // accessing a variable

            //-----------STRING----------------

            string userName; // DECLARING a string variable named, "name"
            userName = "Chris"; // setting a string variable to whatever.....
            Console.WriteLine(userName);
            userName = "Chris";
            Console.WriteLine(userName);

            string firstName;
            string lastName;
            string fullName;
            firstName = "Chris";
            lastName = "Chiasson";
            fullName = firstName + " " + lastName;
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(fullName);

            Console.ReadKey(true); // wait for keypress before exiting...
        }
    }
}
