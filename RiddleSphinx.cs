using System;

class Sphinx
{
  static void Main()
  {
    Console.WriteLine("You have encountered the Sphinx of Egypt. Solve this riddle or be destroyed!");
    Console.WriteLine("I am not alive, but I grow; I don't have lungs, but I need air; I don't have a mouth, but water kills me. What am I?");
    string userAnswer = Console.ReadLine();
    if(userAnswer == "fire" || userAnswer == "Fire")
    {
      Console.WriteLine("Correct! Next Question:");
      Console.WriteLine("What runs around the whole yard without moving?");
      string userAnswer2 = Console.ReadLine();
      if(userAnswer2 == "fence" || userAnswer2 == "Fence")
      {
        Console.WriteLine("You have defeated the Sphinx!");
      }
      else
      {
      Console.WriteLine("You have failed the test, and the Sphinx has eaten you!");
      }
    }
    else
    {
      Console.WriteLine("You have failed the test, and the Sphinx has eaten you!");
    }
  }
}