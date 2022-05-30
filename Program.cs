using game_RPG_DIO.src.Entities;
using static System.Console;


namespace game_RPG_DIO
{
    public class Program
    {
        static void Main(string[] args)
        {
          Knight arus  = new Knight("Arus", 23, "Knight");   
          Wizard wizard  = new Wizard("Jennica", 23, "White Wizard");   
       
          WriteLine(wizard.Attack(1));
          WriteLine(wizard.Attack(7));

          WriteLine(arus.Attack());
          WriteLine(wizard.Attack());
          WriteLine();
        }
    }
}
