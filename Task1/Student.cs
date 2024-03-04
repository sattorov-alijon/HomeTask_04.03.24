namespace Task1;

public class Student : Person
{
    int _numCourses=0;
    List<string>  _courses=new List<string>();
    List<int> _grades=new List<int>();
    public Student(string name, string address) : base(name, address)
    {
    }
    // public override string ToString()
    // {
    //     return base.ToString();
    // }
    public void AddCourseGrade(string course, int grade)
    {
        _courses.Add(course);
        _grades.Add(grade);
    }
    public void PrintGrade()
    {
        foreach (var item in _grades)
        {
            
        System.Console.Write(item+" ");
        }
        System.Console.WriteLine();
    }
    public double GetAverageGrade()
    {
            int sum=0;
        foreach (var item in _grades)
        {
            sum=sum+item;
        }
        return sum/(double)_grades.Count();
    }
    public  string ToString()
    {
        return $"Student: {base.GetName()}({base.GetAddress()})";
    }
}
