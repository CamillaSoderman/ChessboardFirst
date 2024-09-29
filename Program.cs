using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChessBoardFirst
// Camilla Söderman .Net24
// First draft on LAB 2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string whiteBrick = "\u25a1"; // Unicode / UTF-8 code for white square
            string blackBrick = "\u25a0"; // Unicode / UTF-8 codefor black square


            Console.OutputEncoding = System.Text.Encoding.Unicode; //unicode to show the squares, and setting a unicode standard output
            Console.WriteLine("Hello and welcome to the Chessboard!");
            Console.WriteLine("How big board do you want? Write a number:");

            bool success = int.TryParse(Console.ReadLine(), out int number); //check if user input is a number
            int rowColSize = number; // The input number from user

            int[,] chess = new int[number, number]; //Multidimensional array


            //Using the PrintBoard method
            PrintBoard(number, whiteBrick, blackBrick); 


        } 
        //Print out chessboard
        public static void PrintBoard(int rowColSize,string whiteBrick, string blackBrick)
        {

            // Print rows
            for (int i = 0; i < rowColSize; i++)
            {
                //Print columns
                for (int j = 0; j < rowColSize; j++)
                {

                    //White or black brick every other brick
                    string brick = (i + j) % 2 == 0 ? whiteBrick : blackBrick;

                    Console.Write($" {brick} ");
                 
                }
                Console.WriteLine();

            }
        }


    }
}