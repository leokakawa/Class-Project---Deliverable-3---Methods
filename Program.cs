/* Programmer: Leonardo Constante 
 * Date: 9/19/2019
 * Comments: This C# Console application demonstrates a Method example 
 */
using System;

namespace Class_Project___Deliverable_3___Methods
{
    class Program
    {
        static void Main(string[] args)
        {
                // try catch to prevent coding erros
                try
            {
                // Ask for user input
                Console.WriteLine("Please enter your name:");
                string userName = HelloName();

                // Show message to user input
                Console.WriteLine("Hello " + userName + "!");

            }

            catch
            {   //If error in the code, the follow message will appear:
                Console.WriteLine("An error was present in the code. Please try again. ");
            }
        }

                
             private static string HelloName()
        {
            string UserName = Console.ReadLine();

            return UserName;
        }

    }
}