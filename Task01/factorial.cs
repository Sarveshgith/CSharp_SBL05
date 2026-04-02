static double Factorial(int n)
{
    if (n <= 1)
        return 1;

    return n * Factorial(n - 1);
}

Console.WriteLine("Factorial of a Number");
Console.WriteLine("Enter any number: ");

int no = Convert.ToInt32(Console.ReadLine());
double fact = Factorial(no);

Console.WriteLine(fact);