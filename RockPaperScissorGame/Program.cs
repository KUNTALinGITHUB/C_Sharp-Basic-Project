using System;
class Game
{
    public static void Main(string[] args)
    {
        string? inputPlayer;
        string inputCPU;
        int randomInt;

        System.Console.WriteLine("Choose between stone, paper and scissor : ");
        inputPlayer = System.Console.ReadLine();

        Random rnd = new();
        randomInt = rnd.Next(1, 4);

        switch (randomInt)
        {
            case 1:
                inputCPU = "stone";
                System.Console.WriteLine("Computer choose Stone...");
                if (inputPlayer == "stone")
                {
                    System.Console.WriteLine("Drow...");
                }
                else if (inputPlayer == "paper")
                {
                    System.Console.WriteLine("You win...");
                }
                else if (inputPlayer == "scissor")
                {
                    System.Console.WriteLine("You lost...");
                }
                else
                {
                    System.Console.WriteLine("Invalid input....");
                }
                break;
            case 2:
                inputCPU = "paper";
                System.Console.WriteLine("Computer choose paper...");
                if (inputPlayer == "stone")
                {
                    System.Console.WriteLine("You lost....");
                }
                else if (inputPlayer == "paper")
                {
                    System.Console.WriteLine("Drow....");
                }
                else if (inputPlayer == "scissor")
                {
                    System.Console.WriteLine("You Win...");
                }
                else
                {
                    System.Console.WriteLine("Invalid input....");
                }

                break;

            case 3:
                inputCPU = "scissor";
                System.Console.WriteLine("Computer choose scissor...");
                if (inputPlayer == "stone")
                {
                    System.Console.WriteLine("You Win....");
                }
                else if (inputPlayer == "scissor")
                {
                    System.Console.WriteLine("Drow....");
                }
                else if (inputPlayer == "paper")
                {
                    System.Console.WriteLine("You Lost...");
                }
                else
                {
                    System.Console.WriteLine("Invalid input....");
                }


                break;

            default:
                System.Console.WriteLine("Indalid input....");
                break;
        }

    }
}

