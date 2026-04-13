using System;
using System.Diagnostics;
using System.Threading.Tasks;

var stopwatch = Stopwatch.StartNew();

try
{
    var marksTask = GetMarksAsync();
    var attendanceTask = GetAttendanceAsync();
    var profileTask = GetProfileAsync();

    var results = await Task.WhenAll(marksTask, attendanceTask, profileTask);

    Console.WriteLine("\n--- Student Dashboard ---");
    Console.WriteLine($"Marks:       {results[0]}");
    Console.WriteLine($"Attendance:  {results[1]}");
    Console.WriteLine($"Profile:     {results[2]}");
}
catch (Exception ex)
{
    Console.WriteLine($"\n Error occurred: {ex.Message}");
}

stopwatch.Stop();
Console.WriteLine($"\nTotal Time: {stopwatch.ElapsedMilliseconds} ms");

static async Task<string> GetMarksAsync()
{
    await Task.Delay(2000);
    return "Math: 90, CS: 95";
}

static async Task<string> GetAttendanceAsync()
{
    await Task.Delay(3000);
    return "85% Attendance";
}

static async Task<string> GetProfileAsync()
{
    await Task.Delay(2500);

    if (DateTime.Now.Second % 2 == 0)
    {
        throw new Exception("Profile Service Failed");
    }

    return "Name: Sarvesh, Year: 3";
}