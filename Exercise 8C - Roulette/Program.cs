using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8C___Roulette
{
    class Program
    {
         
        static void betMenu()
        {
            Console.WriteLine("              1. Bet on a number\n" +
                "              2. Even/Odds\n" +
                "              3. Red/Black\n" +
                "              4. low/high\n" +
                "              5. row1-12/row13-24/row25-36\n" +
                "              6. columns1/2/3\n" +
                "              7. street e.g. 1-2-3 or 4-5-6\n" +
                "              8. 6 Number double rows e.g. 1-2-3-4-5-6 or 22-23-24-25-26\n" +
                "              9. Spilt at the edge of any two contigous numbers e.g. 1-2, 11-14, 35-36\n" +
               "              10. Corner: at the intersection of any four contigous number 1-2-4-5 or 23-24-26-27\n");
        }
       static void Main(string[] args)
        {
            Console.WriteLine("Choose a number where to bet");
            while (true)
            {
                betMenu();
                int userInput = int.Parse(Console.ReadLine());
                int betNum = 0;
                int amount;
                char temp = 'a';

                int[] numWheel = { 00, 1, 13, 36, 24, 3, 15, 34, 22, 5, 17, 32, 20, 7, 11, 30, 26, 9, 28, 0, 2, 14, 35, 23, 4, 16, 33, 21, 6, 18, 31, 19, 8, 12, 29, 25, 10, 27 };

                char[] colWheel = { 'g', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'g', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b' };
                Random rNum = new Random();
                int rInt = rNum.Next(0, 37);
                int landNum = numWheel[rInt];
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Choose a number");
                        betNum = int.Parse(Console.ReadLine());
                        Console.WriteLine("How much do you want to bet?");
                        amount = int.Parse(Console.ReadLine());
                        if (numWheel[rInt] == betNum)
                        {
                            Console.WriteLine($"You Won! The number landed on {numWheel[rInt]}");
                        }
                        else
                        {
                            Console.WriteLine($"You didnt win, the number landed on {numWheel[rInt]}");   
                        }
                        break;
                    case 2:
                        Console.WriteLine("Odd 1 or Even 2");
                        betNum = int.Parse(Console.ReadLine());
                        Console.WriteLine("How much do you want to bet?");
                        amount = int.Parse(Console.ReadLine());
                        if(numWheel[rInt]%2 == 0 && betNum == 2)
                        {
                            Console.WriteLine($"You Win landed on {numWheel[rInt]}");

                        }
                        else if(numWheel[rInt] %2 ==1 && betNum ==1)
                        {
                            Console.WriteLine($"You Win landed on {numWheel[rInt]}");
                        }
                        else
                            Console.WriteLine($"you lost ball landed on {numWheel[rInt]}");

                        break;

                    case 3:
                        Console.WriteLine("red or black");
                        temp = char.Parse(Console.ReadLine());
                        if (colWheel[rInt] == temp)
                        {
                            Console.WriteLine("you won");
                        }
                        else
                        {
                            Console.WriteLine($"you didnt win {colWheel[rInt]}");
                        }
                        break;

                    case 4:
                        Console.WriteLine("low 1 or high 2");
                        betNum = int.Parse(Console.ReadLine());
                        Console.WriteLine("How much do you want to bet?");
                        amount = int.Parse(Console.ReadLine());
                        if(landNum>=1 && landNum<=18 && betNum == 1)
                        {
                            Console.WriteLine($"You Win landed on {numWheel[rInt]}");

                        }
                        else if(landNum>=19 &&landNum<=36 && betNum ==2)
                        {
                            Console.WriteLine($"You Win landed on {numWheel[rInt]}");
                        }
                        else
                            Console.WriteLine($"you lost ball landed on {numWheel[rInt]}");

                        break;
                    case 5:
                        Console.WriteLine("row 1 or row 2 or row 3");
                        betNum = int.Parse(Console.ReadLine());
                        Console.WriteLine("How much do you want to bet?");
                        amount = int.Parse(Console.ReadLine());
                        if(landNum>=1 && landNum<=12 && betNum == 1)
                        {
                            Console.WriteLine($"You Win landed on {numWheel[rInt]}");
                        }
                        if(landNum>=13 && landNum<=24 && betNum == 2)
                        {
                            Console.WriteLine($"You Win landed on {numWheel[rInt]}");
                        }
                        if(landNum>=25 && landNum<=36 && betNum == 3)
                        {
                            Console.WriteLine($"You Win landed on {numWheel[rInt]}");
                        } 
                        else
                            Console.WriteLine($"you lost ball landed on {numWheel[rInt]}");

                        break;
                    case 6:
                        Console.WriteLine("choose col 1 or col 2 or col 3");
                        betNum = int.Parse(Console.ReadLine());
                        Console.WriteLine("How much do you want to bet?");
                        amount = int.Parse(Console.ReadLine());

                        while (betNum < 36)
                        {
                            if (landNum == betNum)
                            {
                                Console.WriteLine($"You Win landed on {numWheel[rInt]}");
                                break;
                            }
                            betNum += 3;
                        }
                            if(landNum!=betNum)
                                Console.WriteLine($"you lost ball landed on {numWheel[rInt]}");
                        break;

                    case 7:
                        Console.WriteLine("choose a row 1/4/7/10/13/16/19/22/25/28/31/34");
                        betNum = int.Parse(Console.ReadLine());
                        Console.WriteLine("How much do you want to bet?");
                        amount = int.Parse(Console.ReadLine());

                        int tempd = betNum + 3;
                        while(betNum<= tempd)
                        {
                            if(landNum == betNum)
                            {
                                 Console.WriteLine($"You Win landed on {numWheel[rInt]}");
                                break;
                            }
                            betNum += 1;
                        }
                            if(landNum!=betNum)
                                Console.WriteLine($"you lost ball landed on {numWheel[rInt]}");
                        break;
                    case 8:
                        Console.WriteLine("choose a double row:1 4 /4 7/ 7 10/ 13 16/ 19 22/ ");
                        Console.WriteLine("choose a row 1/4/7/10/13/16/19/22/25/28/31/34");
                        betNum = int.Parse(Console.ReadLine());
                        Console.WriteLine("How much do you want to bet?");
                        amount = int.Parse(Console.ReadLine());

                        int tempx= betNum + 5;
                        while(betNum<= tempx)
                        {
                            if(landNum == betNum)
                            {
                                 Console.WriteLine($"You Win landed on {numWheel[rInt]}");
                                break;
                            }
                            betNum += 1;
                        }
                            if(landNum!=betNum)
                                Console.WriteLine($"you lost ball landed on {numWheel[rInt]}");
                        break;


                }

                
            }
            Console.ReadKey();




        }
    }
}
