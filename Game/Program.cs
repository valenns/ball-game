using System;
using System.Runtime.InteropServices;
using Game;

Random rnd = new Random();
Console.WriteLine("Game tst, y to start");

while (Console.ReadLine() == "y")
{
    Console.WriteLine("???");
    double result = rnd.Next(0, 200);
    Console.WriteLine(result);

    if (result < 30)

    {
        Console.WriteLine("you alr lost");
        break;
    }

    Console.WriteLine("It's near you! How many fingers do you use?");
    int fingers = int.Parse(Console.ReadLine());
    while (fingers < 1 || fingers > 5)
    {
        Console.WriteLine("You can only use 1-5 fingers!");
        fingers = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < 5; i++)
    {
        switch (fingers)
        {
            case 1:
                result *= 0.25;
                gameHis.score += 500;
                break;
            case 2:
                result *= 0.5;
                gameHis.score += 250;
                break;
            case 3:
                result *= 0.75;
                gameHis.score += 125;
                break;
            case 4:
                result *= 0.9;
                gameHis.score += 75;
                break;
            case 5:
                result *= 0.95;
                gameHis.score += 50;
                break;
        }
    }

    if (result < 30)
    {
        Console.WriteLine("You found it!");
        gameHis.score += 100;
    }
    else
    {
        Console.WriteLine("You didn't find it!");
    }

    Console.WriteLine(gameHis.score);
}
