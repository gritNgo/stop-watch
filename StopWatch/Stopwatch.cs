using System.Numerics;

public class Stopwatch
{
    public DateTime StartTime { get; set; }
    public DateTime StopTime { get; set; }
    public bool IsRunning = false;


    public TimeSpan Duration
    {
        get
        {
            var duration = StopTime - StartTime;
            return duration;
        }
    }

    public DateTime Start()
    {
        var startTime = DateTime.Now;
        StartTime = startTime;
        return startTime;
    }

    public DateTime Stop()
    {
        var stopTime = DateTime.Now;
        StopTime = stopTime;
        return stopTime;
    }
}