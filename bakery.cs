//
// When the user runs the application, they should receive a prompt with a welcome message along with the cost for both Bread and Pastry.
//
// A user should be able to specify how many loaves of Bread and how many Pastrys they'd like.
//
// The application will return the total cost of the order.
//
// Pierre offers the following deals:
//
// Bread: Buy 2, get 1 free. A single loaf costs $5.
// Pastry: Buy 1 for \$2 or 3 for $5.

namespace BakeryStore
{
  public class Bread
  {
    public int Loaf {get; set;}
    public int BreadCost {get; set;}

    public Bread()
    {
      Loaf = 5;
      BreadCost = 0;
    }

    public int CalculateBread()
    {
      BreadCost = BreadCost + Loaf;
      return BreadCost;
    }

  }

  public class Pastry
  {
    public int Muffin {get; set;}
    public int PastryCost {get; set;}

    public Pastry()
    {
      Muffin = 3;
      PastryCost = 0;
    }

    public int CalculatePastry()
    {
      PastryCost = PastryCost + Muffin;
      return PastryCost;
    }

  }

}
