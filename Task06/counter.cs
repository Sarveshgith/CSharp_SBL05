using System;

delegate void CounterHandler(int count);

class Counter
{
    private int count = 0;
    private int threshold;

    public event CounterHandler OnChange;

    public Counter(int threshold)
    {
        this.threshold = threshold;
    }

    public void Increment()
    {
        count++;
        OnChange?.Invoke(count);
    }
}

class Program
{
    static void Main()
    {
        Counter counter = new Counter(3);

        counter.OnChange += ShowMessage;
        counter.OnChange += ShowAlert;

        for (int i = 0; i < 5; i++)
        {
            counter.Increment();
        }
    }

    static void ShowMessage(int count)
    {
        Console.WriteLine($"Count is {count}");
    }

    static void ShowAlert(int count)
    {
        if (count == 3)
        {
            Console.WriteLine("Threshold reached!");
        }
    }
}