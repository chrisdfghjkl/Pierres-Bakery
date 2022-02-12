namespace Bakery.Models 
{
  public class Pastry
  {
    public int PastryCount {get; set;}

    public Pastry(int pastryCount)
    {
      PastryCount = pastryCount;
    }

    public int PastryCost()
    {
      int pastryPrice = 2;
      int specialPrice = 5;

      if (PastryCount <= 2)
      {
        return pastryPrice * PastryCount;
      }
      else if (PastryCount % 3 != 0)
      {
        return (((PastryCount - (PastryCount % 3)) / 3) * specialPrice) + ((PastryCount % 3) * pastryPrice);
      }
      else 
      {
        return (PastryCount / 3) * specialPrice;
      }
      
      
    }
  }
}