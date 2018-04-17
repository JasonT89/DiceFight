using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceFight
{
    class Battle
    { 
    
        Character battleCharacter = new Character();            
        Program battleProgram = new Program();
        Round battleRound = new Round();
        public void Choice()                                   
        {                                                       
            while (Program.YourHp > 0)
            {
                battleCharacter.ReadName();                       
                battleCharacter.WriteStats();
                Console.WriteLine("\nWhat do you want to do?");
                Console.WriteLine("\nH - Hunt for an opponent");
                Console.WriteLine("R - Retire from fighting");
                var choose = Console.ReadKey();
                switch (choose.Key)
                {
                    case ConsoleKey.H:                                          
                        Console.Clear();                                        
                        battleCharacter.FoeGenerator();                       

                        battleCharacter.ReadName();
                        battleCharacter.WriteStats();
                        Console.WriteLine();

                        

                        Console.ReadKey();
                        while (Program.YourHp > 0 && Program.FoeHp > 0)          
                        {                                                      
                            battleRound.Dice();                                 
                            battleRound.OneRound();
                            Console.ReadKey();
                        }
                        if (Program.YourHp > 0)
                        {
                            Console.WriteLine("Player is victorious!");                     
                            Program.Score = Program.Score + 5;                  
                                         

                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Opponent is victorious!");                     
                            Console.ReadKey();                                  
                            Console.Clear();                                   

                            battleCharacter.Retire();
                            Console.ReadKey();
                            return;
                        }
                        break;
                    case ConsoleKey.R:                                          
                        Console.Clear();                                                
                        battleCharacter.Retire();                                  
                        Console.ReadKey();
                        return;
                    default:
                        Console.Clear();                                       
                        Console.WriteLine("Please try again");                  
                        Console.WriteLine();
                        break;
                }



            }
        }
    }
}
