// See https://aka.ms/new-console-template for more information

using ServiceLayer.Models;





//Console.WriteLine($"Comparison Result: Student1 > Student2: {student1 > student2}");
//Console.WriteLine($"Comparison Result: Student1 < Student2: {student1 < student2}");

Group group = new();
Student student1 = new("Tahir", "Aslanli", 89);
Student student2 = new("Babek", "Aslanli", 60);
Student student3 = new("Ali", "Aslanli", 99);
Student student4 = new("Vusal", "Aslanov", 80);
group.AddStudent(student1);
group.AddStudent(student2);
group.AddStudent(student3);
group.AddStudent(student4);

List<Student> students = new();
foreach (Student student in students)
{
    Console.WriteLine($"{student.Name} {student.Surname} - Point: {student.Point}");
}
 




