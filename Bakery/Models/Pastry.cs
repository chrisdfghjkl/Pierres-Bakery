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
      else 
      {
        return (PastryCount / 3) * specialPrice;
      }
      
      
    }
  }
}