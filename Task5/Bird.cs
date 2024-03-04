using System.ComponentModel;

namespace Task5;

public class Bird
{
    List<int> BirdCount=new List<int>();
    public void AddBirdCount(List<int> values)
    {
        BirdCount=values;
    }
    public bool HasDayWithoutBirds()
    {
        var a=BirdCount.Exists(p=> p==0);   
    
        return a;
    }
}
