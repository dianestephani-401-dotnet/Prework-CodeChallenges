using System;

namespace Lab01a_NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            try
            {
                StartSequence();
            }

            catch
            {
                Console.WriteLine("Oops, that didn't work!");
            }

            finally
            {
                Console.WriteLine("All done!");
            }
            
        }

        static void StartSequence()
        {
            Console.WriteLine("Please enter a number greater than 0.");

            try
            {
                //from https://www.tutorialspoint.com/convert-toint32-method-in-chash
                double doubleNum = 11.32;
                int intNum;
                intNum = Convert.ToInt32(doubleNum);
                Console.WriteLine("Converted {doubleNum} to {intNum}");
            }

            catch
            {
                Console.WriteLine("Sorry, something went wrong.");
            }
        }

    }
}
