using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HelloCSharp
{
    public class Program
    {

        /// <summary>
        /// The entry point to my program
        /// </summary>
        /// <param name="args">the command line arguments</param>
        public static void Main(string[] args) //Main method has to be static; this is where C# starts running
        {

            //DateTime dog;
            //if (DateTime.TryParse(Console.ReadLine(), out dog))
            //{
            //    Console.WriteLine(dog.ToString("D"));
            //}
            //else {
            //    Console.WriteLine("That wasn't a date");
            //}

            //Console.ReadLine();



            //var cat = DateTime.Parse(Console.ReadLine());


            //Console.WriteLine(String.Format("{0:f}", cat));
            //Console.ReadLine();


            //var word = @"\w+"; //absolute verbatim operator


            // Enter email addess
            Console.Write("Email Address:");
            var email = Console.ReadLine();

            // Validate email
            if (!Regex.IsMatch(email, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"))
            {
                Console.WriteLine("Invalid email address!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Email validated");
                Console.ReadLine();


            }
        }

        
        
    }
}
