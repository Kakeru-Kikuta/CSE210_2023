using System.Diagnostics;

class TimeCounter
{
    static void Timer(string[] arge)
    {
        var timer = new Timer(new TimerCallback(TimerCallback));
        timer.Change(0, 5000);
        timer.Change(Timeout.Infinite, Timeout.Infinite);
    }

    static void TimerCallback(object args)
    {
        
    }
    

}