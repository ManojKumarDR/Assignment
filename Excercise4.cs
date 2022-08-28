using System;
namespace Exercises
{
    class SumOfEvenOdd
    {
        public static void Data()
        {
            int[] array = new int[10];

            int evsum = 0;
            int odsum = 0;

            Console.WriteLine("Enter the numbers: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] % 2 == 0)
                {

                    evsum += array[i];
                }
                else
                {
                    odsum += array[i];
                }
            }
                Console.WriteLine($"SUM OF EVEN NUMBERS: {evsum}");
                Console.WriteLine($"SUM OF ODD NUMBERS: {odsum}");

            
        }
            /*int[] evenNumbersarray = new int[10];
            int[] oddNumberarray = new int[10];
            int evenNumbercount = 0;
            int oddNumbercount = 0;

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] % 2 == 0)
                {
                    //Console.WriteLine("The number is Even");
                    evenNumbersarray[evenNumbercount] = array[i];
                    evenNumbercount++;

                }
                else
                {
                    oddNumberarray[oddNumbercount] = array[i];
                    oddNumbercount++;

                }
            }

            
            int evsum = 0;
            for (int i = 0; i < evenNumbercount; i++)
            {
                evsum += evenNumbersarray[i];
                
            }
           
            int odsum = 0;
            for (int i = 0; i < oddNumbercount; i++)
            {
                odsum+=oddNumberarray[i];
            }
            Console.WriteLine($"SUM OF EVEN NUMBERS: {evsum}");
            Console.WriteLine($"SUM OF ODD NUMBERS: {odsum}");


        }*/
            static void Main(string[] args)
            {
                Data();
            }
        }
    }
