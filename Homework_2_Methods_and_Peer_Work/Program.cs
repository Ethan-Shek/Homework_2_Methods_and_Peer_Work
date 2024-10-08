/* IGME.201.01 - Interac Des & Alg Prob Sol III
Ethan Shek and Ella Clevens
*/
namespace Homework_2_Methods_and_Peer_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ethanFavoriteNumber;
            
            //initialize
            ethanFavoriteNumber = 101;

            //start of our actual program
            Console.WriteLine("Ella's favoirte number is: " + ellaFavoriteNumber);
            //delete this after you read this write my favorite number in the console I wrote urs

            /*Partner A Ethan
              Partner B Ella */
            //adding storing variable
            int sum = Add(ethanFavoriteNumber, ellaFavoriteNumber);
            Console.WriteLine("We add our favorite numbers togerther we get: " + sum);


        }
        // this method should return the sum of the 2 intgers
        static int Add(int num1, int num2) 
        {
           return num1 + num2;
        }
    }
}
