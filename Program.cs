using HepsiPayQuiz.Enums;
using HepsiPayQuiz.Models;
using System;

namespace HepsiPayQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Plateau plateau = new Plateau(5, 5);
            Position position = new Position(1, 2);

            // Create rover instance
            Rover rover = new Rover(plateau, position, Direction.N);
            rover.Process("LMLMLMLMM");
            Console.WriteLine(rover.CurrentPosition());


            rover.SetPosition(3, 3, Direction.E);
            rover.Process("MMRMMRMRRM");
            Console.WriteLine(rover.CurrentPosition());
        }
    }
}
