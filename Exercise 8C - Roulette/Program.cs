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
            int[] bets1 = new int[38];
            int odResult = 0;
            char colResult = 'a';
            int lohiResult = 0;
            int dozen = 0;
            int columns = 0;
            int street = 0 ;
            int sixNum = 0;
            int num1Spilt = 0;
            int num2Spilt = 0;
            bool loop = true;
            int[] cornerArr = new int[37];
            int[] numWheel = { 00, 1, 13, 36, 24, 3, 15, 34, 22, 5, 17, 32, 20, 7, 11, 30, 26, 9, 28, 0, 2, 14, 35, 23, 4, 16, 33, 21, 6, 18, 31, 19, 8, 12, 29, 25, 10, 27 };
            char[] colWheel = { 'g', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'g', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b' };

 
            Random rNum = new Random();
            int rInt = rNum.Next(0, 37);

          
            int landNum = numWheel[rInt];
            Console.WriteLine("Choose a number where to bet");
            while (loop)
            {
                betMenu();
                int userInput = int.Parse(Console.ReadLine());
                int betNum = 0;
                int amount;


                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Choose a number");
                        betNum = int.Parse(Console.ReadLine());
                        Console.WriteLine("How much do you want to bet?");
                        amount = int.Parse(Console.ReadLine());
                        bets1[betNum] = amount;
                        
                        break;
                    case 2:
                        Console.WriteLine("Odd 1 or Even 2");
                        odResult = int.Parse(Console.ReadLine());
                        Console.WriteLine("How much do you want to bet?");
                        amount = int.Parse(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("red r or black b");
                        colResult = char.Parse(Console.ReadLine());
                        break;

                    case 4:
                        Console.WriteLine("low 1 or high 2");
                        lohiResult = int.Parse(Console.ReadLine());
                        Console.WriteLine("How much do you want to bet?");
                        amount = int.Parse(Console.ReadLine());
                        break;

                    case 5:
                        Console.WriteLine("row 1 or row 2 or row 3");
                        dozen = int.Parse(Console.ReadLine());
                        Console.WriteLine("How much do you want to bet?");
                        amount = int.Parse(Console.ReadLine());
                        break;

                    case 6:
                        Console.WriteLine("choose col 1 or col 2 or col 3");
                        columns = int.Parse(Console.ReadLine());
                        Console.WriteLine("How much do you want to bet?");
                        amount = int.Parse(Console.ReadLine());

                        break;

                    case 7:
                        Console.WriteLine("choose a row 1/4/7/10/13/16/19/22/25/28/31/34");
                        betNum = int.Parse(Console.ReadLine());
                        Console.WriteLine("How much do you want to bet?");
                        amount = int.Parse(Console.ReadLine());

                        street = amount;

                        break;
                    case 8:
                        Console.WriteLine("choose a double row:1 4 /4 7/ 7 10/ 13 16/ 19 22/ ");
                        Console.WriteLine("choose a row 1/4/7/10/13/16/19/22/25/28/31/34");
                        sixNum = int.Parse(Console.ReadLine());
                        Console.WriteLine("How much do you want to bet?");
                        amount = int.Parse(Console.ReadLine());

                        break;
                    case 9:
                        Console.WriteLine("Choose a two number spilt ");
                        Console.WriteLine("  3 6 9 12 15 18 21 24 27 30 33 36\n" +
                            "  2 5 8 11 14 17 20 23 26 29 32 35\n" +
                            "  1 4 7 10 13 16 19 22 25 28 31 34\n" +
                            "for example 1-4/1-2/8-11");
                        Console.Write("first num ");
                        num1Spilt = int.Parse(Console.ReadLine());
                        
                        Console.Write("second num ");
                        num2Spilt = int.Parse(Console.ReadLine());

                        break;

                    case 10:
                        Console.WriteLine("How much do you want bet?");
                        int amountCorner = int.Parse(Console.ReadLine());

                        Console.WriteLine("Choose a four number corner ");
                        Console.WriteLine("  3 6 9 12 15 18 21 24 27 30 33 36\n" +
                            "  2 5 8 11 14 17 20 23 26 29 32 35\n" +
                            "  1 4 7 10 13 16 19 22 25 28 31 34\n" +
                            "for example 1-4/1-2/8-11");


                        for (int i = 1; i < 5; i++)
                        {
                            int temp = int.Parse(Console.ReadLine());
                            cornerArr[temp] = amountCorner;
                        }
                        break;
                    case 11:
                        loop = false;
                        break;

                }
            }


            if (bets1[landNum]>0)
            {
                Console.WriteLine($"You Won! The number landed on {landNum}");
            }
            else
            {
                Console.WriteLine($"You didnt win for number bet, the number landed on {landNum}");
            }
            
            // even or odd
            if (landNum % 2 == 0 && odResult == 2)
            {
                Console.WriteLine($"You Win landed on {numWheel[rInt]}");

            }
            else if (numWheel[rInt] % 2 == 1 && odResult == 1)
            {
                Console.WriteLine($"You Win landed on {numWheel[rInt]}");
            }
            else
                Console.WriteLine($"you didnt win for odd/even lost ball landed on {numWheel[rInt]}");

            //color red or black

            if (colWheel[rInt] == colResult)
            {
                Console.WriteLine($"you won your color bet it landed on {colWheel[rInt]}");
            }
            else
            {
                Console.WriteLine($"you didnt win your color bet, it landed on {colWheel[rInt]}");
            }


            // lo hi
            if (landNum >= 1 && landNum <= 18 && lohiResult == 1)
            {
                Console.WriteLine($"You Win your low/high, landed on {numWheel[rInt]}");

            }
            else if (landNum >= 19 && landNum <= 36 && lohiResult == 2)
            {
                Console.WriteLine($"You Win your low/high landed on {numWheel[rInt]}");
            }
            else
                Console.WriteLine($"you lost your low/high ball landed on {numWheel[rInt]}");


            // row 1(1-12) 2 3
            if (landNum >= 1 && landNum <= 12 && columns== 1)
            {
                Console.WriteLine($"You Win your row bet landed on {numWheel[rInt]}");
            }
            if (landNum >= 13 && landNum <= 24 && columns == 2)
            {
                Console.WriteLine($"You Win your row bet landed on {numWheel[rInt]}");
            }
            if (landNum >= 25 && landNum <= 36 && columns == 3)
            {
                Console.WriteLine($"You Win your row bet landed on {numWheel[rInt]}");
            }
            else
                Console.WriteLine($"you lost your bet, ball landed on {numWheel[rInt]}");



            //column 1 2 3
            while (columns < 36)
            {
                if (landNum == columns)
                {
                    Console.WriteLine($"You Win your column, landed on {numWheel[rInt]}");
                    break;
                }
                columns += 3;
            }
            if (landNum != columns)
                Console.WriteLine($"you lost your column ball landed on {numWheel[rInt]}");


            //streets
            int tempd = street + 3;
            while (street <= tempd)
            {
                if (landNum == street)
                {
                    Console.WriteLine($"You Win your street bet landed on {numWheel[rInt]}");
                    break;
                }
                street += 1;
            }
            if (landNum != columns)
                Console.WriteLine($"you lost your street bet ball landed on {numWheel[rInt]}");

            //double rows
            int tempx = sixNum + 5;
            while (sixNum <= tempx)
            {
                if (landNum == sixNum)
                {
                    Console.WriteLine($"You Win landed on {numWheel[rInt]}");
                    break;
                }
                sixNum += 1;
            }
            if (landNum != sixNum)
                Console.WriteLine($"you lost ball landed on {numWheel[rInt]}");
            //spilt


            if (landNum == num1Spilt || landNum == num2Spilt)
            {
                Console.WriteLine($"You Win your spilt bet landed on {numWheel[rInt]}");
            }
            else
                Console.WriteLine($"you lost your spilt ball landed on {numWheel[rInt]}");

            // corner bets

            if (cornerArr[landNum] >0)
            {
                Console.WriteLine($"You Win your corner bet landed on {numWheel[rInt]}");
            }
            else
                Console.WriteLine($"you lost your corner bet ball landed on {numWheel[rInt]}");


            Console.ReadKey();
        }
    }
}
