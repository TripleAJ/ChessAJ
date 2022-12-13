using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
     public class Program
    {
         static BoardClass myBoard = new BoardClass(8);

        
        

        static void Main(string[] arge)
        {


            // we will print the board of the chess OR SHOW THE BOARD
            printBoard(myBoard);

            // ask the user for x and y coordination where we will place a piefes

            Cell currentCell = setCurrentCell();
            currentCell.CurrentOccupided = true;

            // calculate all legal moves for that piece
            myBoard.MarkNexLegalMove(currentCell, "Knight");
            // print the chess borard. Use an X for occupid square. Use a + for legal 
            printBoard(myBoard);

            // wait for another key press before ending the program

            Console.ReadLine();
        }

        private static Cell setCurrentCell()
        {
            // get x and y coordinates from a user, and return a cell location is what we are doing here
            Console.WriteLine("Enter the current row number");
            int currentRow = int.Parse(Console.ReadLine());
            // make sure we have error method in case user enter something that is not valid. Before the program crash.
            Console.WriteLine("Enter the current colum number");
            int currentColum = int.Parse(Console.ReadLine());

            return myBoard.theGride[currentRow, currentColum];
        }

        private static void printBoard(BoardClass myBoard)
        {
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    Cell c = myBoard.theGride[i, j];

                    if (c.CurrentOccupided == true)
                    {
                        Console.Write("X");

                    }
                    else if (c.LegalNextMove == true)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();

            }
            Console.WriteLine("-------------------------");
        }

    }
    }

