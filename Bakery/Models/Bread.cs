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
      int loafCost = 5;

      if (LoafCount <= 2)
      {
        return loafCost * LoafCount;
      }
      else
      {
        return (LoafCount / 3) * 10;
      }
    }
  }
}