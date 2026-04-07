using System;
using System.IO;
using System.Collections.Generic;

List<String> error_logs = new List<string>();

try
{
    var logs = File.ReadAllLines("logs.txt");

    foreach (var l in logs)
    {
        var split_logs = l.Split('|');
        if (split_logs[1].Trim() == "ERROR")
        {
            error_logs.Add(split_logs[2].Trim());
        }
    }

    foreach (string l in error_logs)
    {
        System.Console.WriteLine(l);
    }

    File.WriteAllLines("error_logs.txt", error_logs);
}
catch (FileNotFoundException)
{
    System.Console.WriteLine("File Not Found");
}
catch (IOException)
{
    System.Console.WriteLine("IO Exception Found");
}
catch (Exception e)
{
    System.Console.WriteLine("Exception Found: " + e);
}