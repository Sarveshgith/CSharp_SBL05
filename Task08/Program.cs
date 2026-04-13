using System;

class Program
{
    static void Main()
    {
        IRepository<Product> repo = new Repository<Product>();

        while (true)
        {
            Console.WriteLine("\n1. Add  2. View  3. Update  4. Delete  5. Exit");
            int choice = int.Parse(Console.ReadLine()!);

            if (choice == 1)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine() ?? string.Empty;

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine()!);

                repo.Add(new Product { Name = name, Price = price });
            }
            else if (choice == 2)
            {
                var items = repo.GetAll();
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i}: {items[i].Name} - {items[i].Price}");
                }
            }
            else if (choice == 3)
            {
                Console.Write("Index: ");
                int index = int.Parse(Console.ReadLine()!);

                Console.Write("New Name: ");
                string name = Console.ReadLine() ?? string.Empty;

                Console.Write("New Price: ");
                double price = double.Parse(Console.ReadLine()!);

                repo.Update(index, new Product { Name = name, Price = price });
            }
            else if (choice == 4)
            {
                Console.Write("Index: ");
                int index = int.Parse(Console.ReadLine()!);

                repo.Delete(index);
            }
            else if (choice == 5)
            {
                break;
            }
        }
    }
}
