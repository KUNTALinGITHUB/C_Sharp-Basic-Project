using System;

class Game
{
    public static void Main(string[] args)
    {
        Int32 inputUser;
        Int32 inputCom;
        System.Console.WriteLine("Enter a number that you want to guess (between 1 to 20): ");
        inputUser = Convert.ToInt32(System.Console.ReadLine());
        Random rnd = new();

        inputCom = rnd.Next(1,21);
        if (inputCom == inputUser)
        {
            System.Console.WriteLine("{0} provide by both ...\n you guess the right number....\n game end", inputCom);
        }
        else
        {
            System.Console.WriteLine("Guessing wrong one , you enter {0} and computer provide {1}", inputUser, inputCom);
        }
    }
}


// make it by using function call..... 

// make it by using loops for multiple time user input.....
