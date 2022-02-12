using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("==============================");
      Console.WriteLine("| Welcome to Pierre's Bakery |");
      Console.WriteLine("|                            |");
      Console.WriteLine("|       Bread: $5 each       |");
      Console.WriteLine("|      Pastries: $2 each     |");
      Console.WriteLine("|                            |");
      Console.WriteLine("|      Current Specials:     |");
      Console.WriteLine("|  Bread - Buy 2 Get 1 Free  |");
      Console.WriteLine("|      Pastry - 3 For $5     |");
      Console.WriteLine("|                            |");
      Console.WriteLine("==============================");
      Console.WriteLine("");
     
      Console.WriteLine("Welcome to Pierre's, how many loaves of bread would you like?");
      string inputBreadOrder = Console.ReadLine();
      int LoafCount = int.Parse(inputBreadOrder);
      Bread breadOrder = new Bread(LoafCount);
      Console.WriteLine("");

      Console.WriteLine("You got it! Now, how many pastries would you like?");
      string inputPastryOrder = Console.ReadLine();
      int PastryCount = int.Parse(inputPastryOrder);
      Pastry pastryOrder = new Pastry(PastryCount);
      Console.WriteLine("");

      int orderTotal = breadOrder.BreadCost() + pastryOrder.PastryCost();

      Console.WriteLine("Thanks! Your total is $" + orderTotal);
      Console.WriteLine("");
      Console.WriteLine("Would you like to place another order? [Y/N]");
      string userInput = Console.ReadLine();
      if (userInput == "Y" || userInput == "y")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Have a good day!");
      }
      


    }
  }
}