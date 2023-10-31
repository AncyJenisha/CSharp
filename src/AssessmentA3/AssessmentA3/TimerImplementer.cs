namespace AssessmentA3
{
    using System.Timers;

    public class TimerImplementer
    {
        private Timer? processTimer;

        public void SetTimer(int timePeriod)
        {
            processTimer = new System.Timers.Timer(timePeriod);

            processTimer.Elapsed += OnTimedEvent;
            processTimer.AutoReset = false;
            processTimer.Enabled = true;
        }

        public void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Boiler Completed the phase successfully");
            processTimer.Stop();
            processTimer.Enabled = false;
        }
    }
}
