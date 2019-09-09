using System;

namespace IntroToDotnet
{

  class Logic
  {
    public void accept()
    {
      var min = 1m;
      var max = 100m;
      var lower = min;
      var upper = max;
      var guess = Math.Floor((lower + upper) / 2);
      var success = false;
      var input = Console.ReadLine();

      // while loop
      while (!success)
      {
        if (input == "higher")
        {
          lower = guess + 1;
          guess = Math.Floor((lower + upper) / 2);
          Console.WriteLine($"Is your number {guess}?");
          input = Console.ReadLine();
        }
        else if (input == "lower")
        {
          upper = guess - 1;
          guess = Math.Floor((lower + upper) / 2);
          Console.WriteLine($"Is your number {guess}?");
          input = Console.ReadLine();
        }
        else if (input == "yes")
        {
          Console.WriteLine($"Your number is {guess}!");
          Console.WriteLine("Play again?");
          var playAgain = Console.ReadLine();
          if (playAgain == "yes")
          {
            success = false;
            lower = min;
            upper = max;
            guess = Math.Floor((lower + upper) / 2);
            Console.WriteLine("Awesome, let's try again.");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine($"Is your number {guess}?");
            input = Console.ReadLine();
          }
          else if (playAgain == "no")
          {
            success = true;
          }
        }
      }
    }
    class Program
    {
      static void Main(string[] args)
      {
        // user input
        Console.WriteLine("I can guess your number between 1 and 100.");
        System.Threading.Thread.Sleep(1500);
        Console.WriteLine("Think of your number and press 'enter' to begin");
        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        Console.WriteLine($"Is your number {guess}?");
        // creating object of class logic
        Logic logic = new Logic();
        Logic.Accept();

      }
    }
  }
}
