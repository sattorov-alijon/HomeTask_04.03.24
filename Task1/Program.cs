using Task1;

var person = new Person("Alijon","Hamadoni");
System.Console.WriteLine(person.ToString());
var student=new Student("Mansur","Dushanbe");
student.AddCourseGrade("C++",90);
student.AddCourseGrade("HTML",89);
student.AddCourseGrade("C#",80);
student.AddCourseGrade("Java",94);
student.PrintGrade();

System.Console.WriteLine(student.GetAverageGrade());
System.Console.WriteLine(student.ToString());


var teacher=new Teacher("Alijoni Zabiri","Farkhor");
System.Console.WriteLine(teacher.ToString());
System.Console.WriteLine(teacher.AddCourse("C++"));
System.Console.WriteLine(teacher.AddCourse("HTML"));
System.Console.WriteLine(teacher.AddCourse("C#"));
System.Console.WriteLine(teacher.AddCourse(".Net"));
System.Console.WriteLine(teacher.RemoveCourse("C++"));