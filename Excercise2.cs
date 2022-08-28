using System;
namespace Exercises
{
    class EvenOdd
    {
        public static void Data()
        {
           
            
            int[] array = new int[10];
           
            Console.WriteLine("Enter the number : ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());              
            }
            int[] evenNumbersarray = new int[10];
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

            Console.WriteLine("Even Numbers");
            for (int i = 0; i < evenNumbercount; i++)
            {
                Console.WriteLine(evenNumbersarray[i]);
            }
            Console.WriteLine("Odd Numbers");
            for (int i = 0; i < oddNumbercount; i++)
            {
                Console.WriteLine(oddNumberarray[i]);
            }


        }
        static void Main(string[] args)
        {
            Data();
        }
    }
}