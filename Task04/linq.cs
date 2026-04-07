using System;
using System.Collections.Generic;
using System.Linq;

List<Student> students = new List<Student>();

students.Add(new Student("Sarvesh", 21, 85));
students.Add(new Student("Akash", 22, 70));
students.Add(new Student("Arun", 20, 90));

//Filtering based on grade
var filtered_students = students.Where(s => s.grade > 80);

//Sorting based on Name and grade
var sorted_students = students.OrderBy(s => s.name).ThenBy(s => s.grade);

System.Console.WriteLine("Filtered Students: ");
foreach (var s in filtered_students)
{
    Console.WriteLine($"{s.name} - {s.grade} - {s.age}");
}

System.Console.WriteLine("Sorted Students: ");
foreach (var s in sorted_students)
{
    Console.WriteLine($"{s.name} - {s.grade} - {s.age}");
}

class Student
{
    public string name;
    public int age;
    public int grade;

    public Student(string name, int age, int grade)
    {
        this.name = name;
        this.age = age;
        this.grade = grade;
    }
}