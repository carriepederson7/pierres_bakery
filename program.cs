using System;
using System.Collections.Generic;
using System.Linq;
using BakeryStore;

namespace BakeryStore
{
  public class Program
  {
    public static void Main()
    {
      Bread newBread = new Bread();

      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("We sell muffins for $2 and loaves of bread for $5.");
      Console.WriteLine("Loaf Special: Buy 2, get 1 free.");
      Console.WriteLine("Muffin Special: Buy 2, get third muffin for $1.");

      Console.WriteLine("What would you like to buy? loaf/muffin");
      string breadChoice = Console.ReadLine();
      if(breadChoice == "loaf" || breadChoice == "Loaf")
      {
        Console.WriteLine("How many loaves would you like to buy?");
        string stringLoafCount = Console.ReadLine();
        int intLoafCount = int.Parse(stringLoafCount);
        double loafCount = (int)intLoafCount;
        double thirdLoafCount = (int)loafCount / 3;
        Console.WriteLine("Your cost is:");
        Console.WriteLine(newBread.AddLoaf(loafCount, thirdLoafCount));
      }


    }


  }

}
