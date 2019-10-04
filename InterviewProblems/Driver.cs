using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewProblems.Arrays;
using InterviewProblems.LinkedLists;
using InterviewProblems.ModelingProblems;
using InterviewProblems.Strings;

namespace InterviewProblems
{
    class Driver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running interview problems here for testing:");

            // TicTacToe
            int n = 3;
            Console.WriteLine("Starting TicTacToe with board size: " + n);
            ModelingProblems.TicTacToe game = new TicTacToe(n);
            Console.WriteLine("Game results:");
            Console.WriteLine(game.Move(0, 0, 1));
            game.PrintBoard();
            Console.WriteLine(game.Move(0, 2, 2));
            game.PrintBoard();
            Console.WriteLine(game.Move(2, 2, 1));
            game.PrintBoard();
            Console.WriteLine(game.Move(1, 1, 2));
            game.PrintBoard();
            Console.WriteLine(game.Move(2, 0, 1));
            game.PrintBoard();
            Console.WriteLine(game.Move(1, 0, 2));
            game.PrintBoard();
            Console.WriteLine(game.Move(2, 1, 1));
            game.PrintBoard();

            Console.WriteLine();
            n = 2;
            Console.WriteLine("Starting TicTacToe with board size: " + n);

            ModelingProblems.TicTacToe game2 = new TicTacToe(n);
            Console.WriteLine("Game results:");
            Console.WriteLine(game2.Move(0, 1, 1));
            game2.PrintBoard();
            Console.WriteLine(game2.Move(1, 1, 2));
            game2.PrintBoard();
            Console.WriteLine(game2.Move(1, 0, 1));
            game2.PrintBoard();


            // Suspends console after problems are run
            Console.Read();
        }
    }
}
