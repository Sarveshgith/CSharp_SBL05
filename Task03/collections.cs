using System;
using System.Collections.Generic;

List<string> items = new List<string>();

Console.WriteLine("Task/Name Manager");
Console.WriteLine("Enter 'add', 'remove', 'display', or 'exit':");

while (true)
{
    Console.Write("\nCommand: ");
    string command = Console.ReadLine().Trim().ToUpper();

    if (command == "ADD")
    {
        Console.Write("Enter item: ");
        string item = Console.ReadLine().Trim();
        items.Add(item);
        Console.WriteLine("Item added.");
    }
    else if (command == "REMOVE")
    {
        DisplayItems(items);
        Console.Write("Enter index to remove: ");
        if (int.TryParse(Console.ReadLine().Trim(), out int index) && index > 0 && index <= items.Count)
        {
            items.RemoveAt(index - 1);
            Console.WriteLine("Item removed.");
        }
        else
            Console.WriteLine("Invalid index.");
    }
    else if (command == "DISPLAY")
    {
        DisplayItems(items);
    }
    else if (command == "EXIT")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid command.");
    }
}

static void DisplayItems(List<string> items)
{
    if (items.Count == 0)
    {
        Console.WriteLine("No items.");
        return;
    }

    Console.WriteLine("Items:");
    for (int i = 0; i < items.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {items[i].Trim().ToUpper()}");
    }
}
