using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DiceFight
{
    class Character
    {
        

        Program characterProgram = new Program();                               
        public static Random YouRng = new Random();                             

        public static int Str = YouRng.Next(1, 7);
        public static int Dmg = YouRng.Next(1, 7);
        public static int Hp = YouRng.Next(1, 11);
        

        public void YourStats()
        {
            Program.YourStr = Str;                                            
            Program.YourDmg = Dmg;
            Program.YourHp = Hp;
        }
        public void WriteStats()
        {
           
            Console.WriteLine("Strength: " + Program.YourStr);                  
            Console.WriteLine("Damage: " + Program.YourDmg);
            Console.WriteLine("Health: " + Program.YourHp);
        }


        public void YourName()
        {
            Console.WriteLine("Enter the name of your character");                              
            string Name = Console.ReadLine();
            Program.YourName = Name;
            Console.Clear();
        }
        public void ReadName()
        {
            Console.WriteLine("\nName: " + Program.YourName);                     
        }

        
        public void FoeGenerator()                                              
        {
            Random boo = new Random();
            int name0 = boo.Next(1, 6);
            string names = "Name: ";

            switch (name0)
            {
                case 1:
                    names = "Isaac";
                    break;

                case 2:
                    names = "Linus";
                    break;

                case 3:
                    names = "Daniel";
                    break;

                case 4:
                    names = "Mikael";
                    break;

                case 5:
                    names = "Jonathan";
                    break;

            }
        
        
        
            Random FoeRng = new Random();
            Program.FoeStr = FoeRng.Next(1, 7);
            Program.FoeDmg = FoeRng.Next(1, 7);
            Program.FoeHp = FoeRng.Next(1, 11);
            
            Console.WriteLine("Name: " + names);
            Console.WriteLine("Stength: " + Program.FoeStr);
            Console.WriteLine("Damage: " + Program.FoeDmg);
            Console.WriteLine("Health: " + Program.FoeHp);
        }

        public void Retire()
        {
            Console.WriteLine("Final Statistics: ");
            ReadName();
            
            Console.WriteLine("Strength: " + Program.YourStr);                 
            Console.WriteLine("Damage: " + Program.YourDmg);                  
            Console.WriteLine("Health: " + Program.YourHp);                  
            if (Program.YourHp > 0)
            {
                
                Program.Score = Program.Score + Program.YourHp;
                Program.Score = Program.Score + 5;
                
            }
            else
            {
                              
            }
            Console.WriteLine("Your Score: " + Program.Score);           
            Program.FoeNames.ForEach(Console.WriteLine);

        }
    }
}
