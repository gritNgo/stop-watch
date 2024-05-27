Stopwatch stopwatch = new Stopwatch();

Console.WriteLine("*****************************************************************");
Console.WriteLine("                            STOPWATCH               ");
Console.WriteLine("*****************************************************************");

while (true)
{
    if (stopwatch.IsRunning == false)
    {
        Console.WriteLine();
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
        Console.WriteLine("Started. " + (startTime - startTime));
    }

    else if (input.ToLower() == "start" && stopwatch.IsRunning == true)
    {
        Console.WriteLine("Stopwatch is already running");
        continue;
    }
    else if (input.ToLower() == "stop" && stopwatch.IsRunning == false)
    {
        Console.WriteLine("Stopwatch is already stopped");
        continue;
    }

    else if (input.ToLower() == "stop")
    {
        stopwatch.IsRunning = false;
        var endTime = stopwatch.Stop();
        Console.WriteLine("Stopped. Duration: " + stopwatch.Duration);
        Console.WriteLine();
        Console.WriteLine("____________________________________________________________");
    }

    else if (input.ToLower() == "exit")
    {
        Console.WriteLine("Exited");
        break;
    }

    else
    {
        Console.WriteLine("Invalid Input");
        continue;
    }
}
