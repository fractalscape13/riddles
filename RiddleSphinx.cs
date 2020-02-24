using System;
using System.Collections.Generic;

class Sphinx
{  
  static void Main()
  {
    AskRiddle();
    bool isCorrect = true;
    while (isCorrect)
    {
      isCorrect = AskRiddle();
    }
    Console.WriteLine("You lose.");
  }

  static bool AskRiddle()
  {
    string[] riddles = { "I am not alive, but I grow; I don't have lungs, but I need air; I don't have a mouth, but water kills me. What am I?", "What runs around the whole yard without moving?", "What can you catch but never throw?" };
    string[] answers = { "fire", "fence", "a cold" };
    Random rnd = new Random();
    int randomIndex = rnd.Next(0,3);
    Console.WriteLine(riddles[randomIndex]);
    string userAnswer = Console.ReadLine();
    if(userAnswer == answers[randomIndex])
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}