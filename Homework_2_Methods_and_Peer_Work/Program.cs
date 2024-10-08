/* IGME.201.01 - Interac Des & Alg Prob Sol III
Ethan Shek and Ella Clevens
October 13, 2024 */
namespace Homework_2_Methods_and_Peer_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ethanFavoriteNumber;
            int ellaFavoriteNumber;
            
            //initialize
            ethanFavoriteNumber = 101;
            ellaFavoriteNumber = 3;

            //function inside main method
            static int Subtract(int num1, int num2)
            {
                return num1 - num2;
            }

            //start of our actual program
            Console.WriteLine("Ella's favorite number is: " + ellaFavoriteNumber);
            Console.WriteLine("Ethan's favorite number is: " + ethanFavoriteNumber);

            /*Partner A Ethan
              Partner B Ella */
            //adding storing variable
            int sum = Add(ethanFavoriteNumber, ellaFavoriteNumber);
            Console.WriteLine("We add our favorite numbers togerther we get: " + sum);

            //subtract method
            int difference = Subtract(ethanFavoriteNumber, ellaFavoriteNumber);
            Console.WriteLine("We subtract Ella's favorite number from Ethan's favorite number and we get: " + difference);


        }
        // this method should return the sum of the 2 intgers
        //auto comment:
        /// <summary>
        /// This method should return the sum of the 2 integers
        /// </summary>
        /// <param first number ="num1"></param>
        /// <param second number ="num2"></param>
        /// <returns></returns>
        static int Add(int num1, int num2) 
        {
           return num1 + num2;
        }
    }
}
