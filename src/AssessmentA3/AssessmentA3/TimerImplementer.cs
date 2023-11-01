namespace AssessmentA3
{
    using System.Timers;

    /// <summary>
    /// TimerImplementer -  Has Timer method to check the timer operations
    /// </summary>
    public class TimerImplementer
    {
        /// <summary>
        /// Calls an event on elapsed time.
        /// </summary>
        private Timer? processTimer;

        /// <summary>
        /// Has if the process is completed without interuption.
        /// </summary>
        private bool completeStatus;

        /// <summary>
        /// Sets the timer with the time interval specified.
        /// </summary>
        /// <param name="timePeriod">Time period for the timer to invoke the event.</param>
        public void SetTimer(int timePeriod)
        {
            processTimer = new System.Timers.Timer(timePeriod);

            processTimer.Elapsed += OnTimedEvent;
            processTimer.AutoReset = false;
            processTimer.Enabled = true;
            while (true)
            {
                if(completeStatus)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Event to be executed when timer is elapsed.
        /// </summary>
        /// <param name="source">The source object from timer class</param>
        /// <param name="e">Data for the event</param>
        public void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            completeStatus = true;
            Console.WriteLine("Boiler Completed the phase successfully\n\n");
            processTimer.Enabled = false;
        }
    }
}
