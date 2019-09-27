
namespace BakeryStore
{
  public class Bread
  {
    // public string Loaf {get; set;}
    public int LoafCost {get; set;}
    public int BreadCount {get; set;}

    public Bread()
    {
      // Loaf = "loaf";
      LoafCost = 0;
      BreadCount = 0;
    }

    public int AddLoaf(int loafCount)
    {
      LoafCost = loafCount * 5;
      BreadCount ++;
      return LoafCost;
    }

  }

  // public class Pastry
  // {
  //   public int Muffin {get; set;}
  //   public int PastryCost {get; set;}
  //   public int PastryCount {get; set;}
  //
  //   public Pastry(string breadChoice)
  //   {
  //     MuffinCost = 2;
  //     PastryCount = 0;
  //   }
  //
  //   public int CalculatePastry()
  //   {
  //     PastryCost = PastryCost + Muffin;
  //     PastryCount ++;
  //     return PastryCost;
  //   }
  //
  // }

}
