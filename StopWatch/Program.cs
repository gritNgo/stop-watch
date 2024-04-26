Stopwatch stopwatch = new Stopwatch();

while (true)
{
    if (stopwatch.IsRunning == false)
    {
        Console.Write("Enter 'start' to start stopwatch or 'exit' to exit program: ");
    }

    else
    {
        Console.Write("Enter 'stop' to stop stopwatch or 'exit' to exit program: ");
    }
    var input = Console.ReadLine();

    if (input.ToLower() == "start" && stopwatch.IsRunning == false)
    {
        stopwatch.IsRunning = true;
        var startTime = stopwatch.Start();
        Console.WriteLine("Started. " + startTime.ToString("T"));
    }

    else if (input.ToLower() == "start" && stopwatch.IsRunning == true)
    {
        throw new InvalidOperationException("Stopwatch already running.");
    }
    else if (input.ToLower() == "stop" && stopwatch.IsRunning == false)
    {
        throw new InvalidOperationException("Stopwatch already stopped.");
    }

    else if (input.ToLower() == "stop")
    {
        stopwatch.IsRunning = false;
        var endTime = stopwatch.Stop();
        Console.WriteLine("Stopped. Duration: " + stopwatch.Duration);
    }

    else if (input.ToLower() == "exit")
    {
        break;
    }

    else
    {
        Console.WriteLine("Invalid Input.");
        continue;
    }
}
