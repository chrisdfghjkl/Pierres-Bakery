namespace Bakery.Models
{
  public class Bread
  {
    public int LoafCount {get; set;}

    public Bread(int loafCount)
    {
      LoafCount = loafCount;
    }

    public int BreadCost()
    {
      int loafPrice = 5;
      return loafPrice * LoafCount;
    }
  }
}