using System.ComponentModel;

namespace Task6;

public class Bird
{
    List<int> BirdCount=new List<int>();
    public void AddBirdCount(List<int> values)
    {
        BirdCount=values;
    }
    public int CountForFirstDays(int a)
    {
        
        return         BirdCount.Take(a).Sum();

    }
}
