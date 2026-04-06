Person p1 = new Person("Sarvesh", 21);
Person p2 = new Person("Akash", 22);

p1.Introduce();
p2.Introduce();
class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Introduce()
    {
        System.Console.WriteLine($"Welcome! {name} of Age {age}");
    }
}
