using System.ComponentModel;

namespace Task3;

public class Bird
{
    List<int> BirdCount=new List<int>();
    public void AddBirdCount(List<int> values)
    {
        BirdCount=values;
    }
    public int Today()
    {
      return BirdCount[BirdCount.Count-1];
    }
}
