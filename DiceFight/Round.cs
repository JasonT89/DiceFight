using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceFight
{
    class Round
    {
        public void Dice()
        {
            Random DiceRng = new Random();
            int dice = DiceRng.Next(1, 7);
            Program.YourDice = dice;
            int badDice = DiceRng.Next(1, 7);
            Program.FoeDice = badDice;
        }
        public void OneRound()
        {
            int YourResult = Program.YourStr + Program.YourDice;
            int FoeResult = Program.FoeStr + Program.FoeDice;
            
            if (YourResult > FoeResult)
            {
                Program.FoeHp = Program.FoeHp - Program.YourDmg;
                Console.WriteLine("-------------------");               
                Console.WriteLine(Program.YourName + " won this round :");
                Console.WriteLine(YourResult + " (" + Program.YourStr + " + " + Program.YourDice + " )" + " > " + FoeResult + " (" + Program.FoeStr + " + " + Program.FoeDice + ")");
                Console.WriteLine( "Player's current health: " + Program.YourHp + " | "  + "Opponent's current health: " + Program.FoeHp);
                Console.WriteLine();
            }
            else if (FoeResult > YourResult)
            {
                Program.YourHp = Program.YourHp - Program.FoeDmg;
                Console.WriteLine("--------------------");             
                Console.WriteLine(Program.YourName + " lost this round :");
                Console.WriteLine(YourResult + " (" + Program.YourStr + " + " + Program.YourDice + " )" + " < " + FoeResult + " (" + Program.FoeStr + " + " + Program.FoeDice + ")");
                Console.WriteLine("Player's current health: " + Program.YourHp + " | " + "Opponent's current health: " + Program.FoeHp);
                Console.WriteLine();                
            }
            else
            {
                Console.WriteLine("--------------------");

                Console.WriteLine("Evenly matched, the combatants circle each other, looking for a better opportunity.");
                Console.WriteLine(YourResult + " (" + Program.YourStr + " + " + Program.YourDice + ")" + " = " + FoeResult + " (" + Program.FoeStr + " + " + Program.FoeDice + ")");
                Console.WriteLine("Player's current health: " + Program.YourHp + " | " + "Opponent's current health: " + Program.FoeHp);
                Console.WriteLine();
            }
        }
    }
}
