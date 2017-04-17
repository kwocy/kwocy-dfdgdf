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
            
        int a;
            int x;
            Console.WriteLine("\t\t\t\t-Gladiators-");
            Console.WriteLine("\t Еще день назад, Вы были отличным воином, который шел со своими  \nтоварищами на Рим. А сегодня Вы просыпаетесь в грязной клетке. Голова болит так что вы пытаетесь вспомнить свое имя, но одно вы знаете точно скоро вам \nпридеться сражаться за жизнь. ");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\tВведите имя героя: ");
            Hero Pers = new Hero();
            Pers.NamePer();
            Hero Pers1 = new Hero();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\tНажмите 0 для начала");
            Console.WriteLine("--------------------------------------------------------------------------------");
            x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 0:
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.WriteLine("\tВыберите действие: \n1-Характеристики персонажа \n2-Зал спорта \n3-В бой");
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a == 1)
                    {
                        Console.WriteLine();
                        Pers.Print();
                    }
                    else if (a == 2)
                    {
                        int c;
                        Console.WriteLine("--------------------------------------------------------------------------------");
                        Console.WriteLine("\t\t\t--Добро пожаловать в Зал физической культуры--");
                        Console.WriteLine("--------------------------------------------------------------------------------");
                        Console.WriteLine("\tЧем вы хотите заняться: \n1-Пробежать кросс \n2-Побить грушу \n3-Пофехтовать \n4-Заняться силовыми упражнениями ");
                        c = Convert.ToInt32(Console.ReadLine());
                        if (c == 1)
                        {
                            Pers.Stamina = Pers.Stamina + 5;
                            Pers.Speed = Pers.Speed + 6;
                            Pers.Raiting = Pers.Power + Pers.Speed + Pers.Stamina;
                            Console.WriteLine("Ваша скорость и выносливасть улучшены");
                            Console.WriteLine("--------------------------------------------------------------------------------");
                        }
                        else if (c == 2)
                        {
                            Pers.Stamina = Pers.Stamina + 3;
                            Pers.Power = Pers.Power + 4;
                            Pers.Raiting = Pers.Power + Pers.Speed + Pers.Stamina;
                            Console.WriteLine("Ваша сила и выносливасть улучшены");
                            Console.WriteLine("--------------------------------------------------------------------------------");
                        }
                        else if (c == 3)
                        {
                            Pers.Speed = Pers.Speed + 7;
                            Pers.Stamina = Pers.Stamina + 4;
                            Pers.Raiting = Pers.Power + Pers.Speed + Pers.Stamina;
                            Console.WriteLine("Ваша скорость и выносливасть улучшены");
                            Console.WriteLine("--------------------------------------------------------------------------------");
                        }
                        else if (c == 4)
                        {
                            Pers.Power = Pers.Power + 5;
                            Pers.Raiting = Pers.Power + Pers.Speed + Pers.Stamina;
                            Console.WriteLine("Ваша сила улучшена");
                            Console.WriteLine("--------------------------------------------------------------------------------");
                        }
                    }
                    else if (a == 3)
                    {
                        Console.WriteLine("--------------------------------------------------------------------------------");
                        Console.WriteLine("Приветствуем на арене, "+Pers.Name);
                        Console.WriteLine("--------------------------------------------------------------------------------");
                        Pers.Namee();
                        Pers.Print();
                        Console.WriteLine("--------------------------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t-VS-");
                        Console.WriteLine();
                        Pers1.NameProt();
                        Pers1.Print();
                        if (Pers.Raiting > Pers1.Raiting)
                        {
                            Console.WriteLine();
                            Console.WriteLine("************************************WIN************************************");
                            Console.WriteLine("Победил:" + Pers.Name);
                            Console.WriteLine("****************************************************************************");
                        }
                        else
                        {
                            Console.WriteLine("*************************************LOSE***********************************");
                            Console.WriteLine("Победил:" + Pers1.ame);
                            Console.WriteLine("****************************************************************************");
                        }
                        if (Pers.Raiting > Pers1.Raiting)
                        {
                            Pers1.Speed = Pers1.Speed + 5;
                            Pers1.Power = Pers1.Power + 4;
                            Pers1.Stamina = Pers1.Stamina + 3;
                            Pers1.Raiting = Pers1.Power + Pers1.Speed + Pers1.Stamina;

                        }

                        

                    }

                    goto case 0;



            }

            }
           
        
    
    
               
        
        
                  
          
        class Hero
        {
            public static int count = 0;
            public string Name;
            public double Speed;
            public double Power;
            public double Raiting;
            public double Stamina;
            public string name;
            public double speed;
            public double power;
            public double raiting;
            public double stamina;
            public double b;
            public string ame;
            
            public void Print()
            {
                Console.WriteLine("Speed -" + Speed);
                Console.WriteLine("Power -" + Power);
                Console.WriteLine("Stamina -" + Stamina);
                Console.WriteLine("Raiting -" + Raiting);
            }
            
            public void NamePer()
            {
                Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Имя персонажа: " + Name);
            }
            public void Namee()
            {
                Console.WriteLine("Имя персонажа: " + Name);
            }
            public void NameProt()
            {
                Random rand = new Random();
                b = rand.Next(100);
                if (b<=20)
                {
                    
                    Console.WriteLine("Имя противника: Вася");
                    ame = "Вася";
                }
                else if (b <= 40 && b > 20)
                {
                    Console.WriteLine("Имя противника: Иван");
                    ame = "Иван";
                }
                else if (b <=60 && b > 40)
                {
                    Console.WriteLine("Имя противника: Пидор");
                    ame = "Пидор";
                }
                else if (b <= 100 && b>60)
                {
                    Console.WriteLine("Имя противника: Nautilus");
                    ame = "Nautilus";
                }
            }
            public Hero()
            {  
            

                Random rand = new Random();
                Power = rand.Next(100);
                Random rand1 = new Random();
                Speed = rand.Next(100);
                Random rand2 = new Random();
                Stamina = rand.Next(100);
                Raiting = Power + Speed+ Stamina;

                this.name = Name;
                this.speed = Speed;
                this.power = Power;
                this.raiting = Raiting;
                this.stamina = Stamina;
            }
        }
      }
 }
            


    

  

        

    
