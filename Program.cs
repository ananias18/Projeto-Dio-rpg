using System;
using Projeto_Dio.src.Entities;

namespace Projeto_Dio
{
    class Program
    {
        static void Main(string[] args)
        {
            Character knight = new Knight("Arus", 23, "Knight");
            Character wizard = new Wizard("Jennica", 23, "White Wizard");
            Character ninja = new Ninja("Wedge", 23, "Ninja");
            Character blackwizard = new BlackWizard("Topapa", 23, "Black Wizard");

            Console.WriteLine(knight.Attack(1));
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(ninja.Attack(7));
            Console.WriteLine(blackwizard.Attack());
            

        }
    }
}