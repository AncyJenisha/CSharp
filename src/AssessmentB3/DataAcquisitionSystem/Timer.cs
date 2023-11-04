using System.Timers;

namespace DataAcquisitionSystem
{
    public class Timer
    {
        private static System.Timers.Timer timer;
        public void SetTimer(long timeInterval)
        {
            timer = new System.Timers.Timer(timeInterval);
            timer.Elapsed += OnTimedEvent;
            timer.Enabled = true;
            timer.AutoReset = true;
        }

        public void OnTimedEvent(object source, ElapsedEventArgs elapsedEventArgs)
        {
            DataAcquisitior dataAcquisitior = new();
            dataAcquisitior.GenerateData();
            timer.Enabled = false;
            timer.Stop();
        }
    }
}