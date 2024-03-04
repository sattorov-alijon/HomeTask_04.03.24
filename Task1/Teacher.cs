namespace Task1;

public class Teacher: Person
{
    int _numCourses=0;
    List<string>  _courses=new List<string>();
    public Teacher(string name, string address) : base(name, address)
    {
    }
    // public override string ToString()
    // {
    //     return base.ToString();
    // }
    public bool AddCourse(string course)
    {
        var a=0;
        foreach (var item in _courses)
        {
            if (item==course)
            {
                a=1;
            }
        }
             if (a==1)
             return false;
             else return true;
        _courses.Add(course);
    }
    public bool RemoveCourse(string course)
    {
         var a=0;
        foreach (var item in _courses)
        {
            if (item==course)
            {
                a=1;
            }
        }
             if (a==0)
             return false;
             else return true;
    }
    public  string ToString()
    {
        return $"Teacher: {base.GetName()}({base.GetAddress()})";
    }
}



