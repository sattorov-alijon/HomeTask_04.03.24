using System.ComponentModel;

namespace Task4;

public class Bird
{
    List<int> BirdCount=new List<int>();
    public void AddBirdCount(List<int> values)
    {
        BirdCount=values;
    }
    public int Today()
    {
      return BirdCount[BirdCount.Count-1]+1;
    }
}
