using System;

namespace Application
{
    class Program
    {
        static void Main()
        {
            //Integer "tal1" is declared
            int tal1;
            //Integer "tal1" is declared
            int tal2;
            //Integer "snit" is declared
            int snit;
            //Prints text that asks you for the number which will be assigned to tal1
            Console.Write("Indtast det første tal: ");
            //Converts ReadLine to Int32, so we can use Console.ReadLine to get input in integers
            tal1 = Convert.ToInt32(Console.ReadLine());
            
            //Clears terminal
            Console.Clear();

            //Prints text that asks you for the number which will be assigned to tal2
            Console.Write("Indtast det andet tal: ");
            //Converts ReadLine to Int32, so we can use Console.ReadLine to get input in integers
            tal2 = Convert.ToInt32(Console.ReadLine());

            //Clears terminal
            Console.Clear();

            //Adds tal1 and tal2 together and divides them by 2 and then adds the result to 'snit'
            snit = (tal1 + tal2) / 2;

            //Prints the average of the 2 numbers which was stored in "snit"
            Console.Write("Gennemsnittet for de 2 tal er: {0}", snit);
        }
    }
}