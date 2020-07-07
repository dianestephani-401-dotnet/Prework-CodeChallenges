using System;
using System.Transactions;

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
                double input = 11.32;
                int doubleNum;
                doubleNum = Convert.ToInt32(input);
                Console.WriteLine("Converted {input} to {doubleNum}");
                int[] IntegerArray = new int[0];
                Populate(IntegerArray);
                GetSum(IntegerArray);
                GetProduct(IntegerArray, IntegerSum);
                GetQuotient(IntegerProduct);
            }

            catch
            {
                Console.WriteLine("Sorry, something went wrong.");
            }
        }

        static void Populate()
        {

        }

    }
}
