using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя героя");
            Hero Pers = new Hero();
            Console.WriteLine();
            Console.WriteLine("Введите имя второго героя");
            Hero Pers2 = new Hero();
            if (Pers.Raiting > Pers2.Raiting)
            {
                Console.WriteLine("Победил:" + Pers.Name);
            }
            else
            {
                Console.WriteLine("Победил:" + Pers2.Name);
            }

            Console.ReadLine();
            
          

        }
        class Hero
        {
            public static int count = 0;
            public string Name;
            public double Speed;
            public double Power;
            public double Raiting;
            
            public Hero()
            {
                Name = Convert.ToString(Console.ReadLine());
                Random rand = new Random();
                Power = rand.Next(100);
                Random rand1 = new Random();
                Speed = rand.Next(100);
                
                Raiting = Power + Speed;
                count++;
                Print();
            }   
                public void Print()
            {
                Console.WriteLine("Name -" + Name);
                Console.WriteLine("Speed -" + Speed);
                Console.WriteLine("Power -" + Power);
                Console.WriteLine("Raiting -" + Raiting);
            }
                
            
            
              
        }
        
    }
}