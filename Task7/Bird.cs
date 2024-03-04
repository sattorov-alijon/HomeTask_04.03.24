using System.ComponentModel;

namespace Task7;

public class Bird
{
    List<int> BirdCount=new List<int>();
    public void AddBirdCount(List<int> values)
    {
        BirdCount=values;
    }
    public int BusyDays()
    {
        
        return BirdCount.Count(p=> p>4);

    }
}
