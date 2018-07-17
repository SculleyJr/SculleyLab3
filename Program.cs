using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            bool runProgram = true;
            string name;
            while (runProgram)

            {
                string input;

                Console.WriteLine("Hello, Please Enter Your Name");
                name = Console.ReadLine();

               
                Console.WriteLine($"Hello," + name + " pick a number between 1 and 100");
                int i = int.Parse(Console.ReadLine());

                if (i > 0 && i < 101)
                {
                    {
                        if (i % 2 == 0)
                            if (i < 26)
                            {
                                Console.WriteLine("Even and less than 25");
                            }
                        if (i % 2 == 0 && i > 25 && i < 61)
                        {
                            Console.WriteLine("Even");
                        }
                        if (i % 2 == 0 && i > 60)
                        {
                            Console.WriteLine(i + " Even");
                        }
                        else
                        {
                            Console.WriteLine($"Odd " + (i));
                        }


                    }
                }
                else Console.WriteLine("number not valid");

                Console.WriteLine("Press (Y) to continue, or press any other key to quit");
                input = Console.ReadLine();



                if (input.ToLower() == "y")
                { runProgram = true; }
                else
                { runProgram = false; }
            }

            
        }

    }
}
