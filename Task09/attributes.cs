using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class RunnableAttribute : Attribute
{
}

class MyTasks
{
    [Runnable]
    public void Task1()
    {
        Console.WriteLine("Task1 executed");
    }

    [Runnable]
    public void Task2()
    {
        Console.WriteLine("Task2 executed");
    }

    public void NotRunnable()
    {
        Console.WriteLine("This should NOT run");
    }
}

class Program
{
    static void Main()
    {
        var assembly = Assembly.GetExecutingAssembly();

        foreach (var type in assembly.GetTypes())
        {
            foreach (var method in type.GetMethods())
            {
                if (method.GetCustomAttribute<RunnableAttribute>() != null)
                {
                    Console.WriteLine($"Running: {method.Name}");

                    // Create object
                    var obj = Activator.CreateInstance(type);

                    //Invoking method
                    method.Invoke(obj, null);
                }
            }
        }
    }
}