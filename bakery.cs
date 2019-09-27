
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

  public class Pastry
  {
    public double PastryCost {get; set;}

    public Pastry()
    {
      PastryCost = 2;
    }

    public double AddPastry(double pastryCount, double thirdPastryCount)
    {
      PastryCost = pastryCount * 2;
      if(pastryCount > 2)
      {
        PastryCost = (pastryCount * 2) - thirdPastryCount;
      }

      return PastryCost;
    }

  }

}
