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
      
      return pastryPrice * PastryCount;
    }
  }
}