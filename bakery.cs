
namespace BakeryStore
{
  public class Bread
  {
    public double LoafCost {get; set;}

    public Bread()
    {
      LoafCost = 0;
    }

    public double AddLoaf(double loafCount, double thirdLoafCount)
    {
      LoafCost = loafCount * 5;
      if(loafCount > 2)
      {
        LoafCost = (loafCount * 5) - (thirdLoafCount * 5);
      }
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
