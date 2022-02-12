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
      else if (LoafCount % 3 != 0)
      {
        int breadSpecial = loafCost * ((LoafCount - (LoafCount % 3)) / 3);
        return (LoafCount * loafCost) - breadSpecial;
      }
      else
      {
        return (LoafCount / 3) * 10;
      }
    }
  }
}