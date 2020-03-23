using System;
using System.Globalization;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("What is your Message? ");
                string input = Console.ReadLine();
                input = input.ToUpper(new CultureInfo("en-US", false)); //Turn input to uppercase

                string message = "Your encoded message is ";
                Console.WriteLine(message);
                foreach (char c in input)
                {
                    Console.WriteLine("-{0}" , Message(c));
                }
                Console.WriteLine("Message checksum is ");
                foreach (char c in input) 
                {
                    int checksum = ((int)c); //Unicode values
                    
                    Console.WriteLine(checksum);
                }
                
                
            }

            static int Message(char ch)
            {
                // A-Z == 1-26
                if (ch >= 'A' && ch <= 'Z')
                {
                    ch -= (char)('A' - 1);
                }
                else
                {
                    ch = '\0'; // all other characters use binary zero
                }

                return (int)ch;
            }
            
        }
    }
}
