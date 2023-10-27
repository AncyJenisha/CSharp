using System.Security.Cryptography.X509Certificates;

namespace AssessmentA3
{
    public class Boiler
    {
        public object InterLock = new object();

        public bool Switch = false;

        public string? SystemStatus { get; set; }

        public Boiler(string initialStatus)
        {
            SystemStatus = initialStatus;
        }

        public void  BoilerSequence()
        {
            if (Switch)
            {

                PrePurgePhase();
                IgnitionPhase();
                OperationalPhase();

            }
            else
            {
                Console.WriteLine("Switch is opened, toggle it to start boiler");
            }
        }
        public void PrePurgePhase()
        {
            lock (InterLock)
            {
                DateTime dateTime = DateTime.Now;
                System.Timers.Timer timer = new System.Timers.Timer(100000);
                timer.Start();
                SystemStatus = "Pre-Purge";
                timer.Stop();
                BoilerSequenceDetails boilerSequenceDetails = new();
                boilerSequenceDetails.Time = dateTime;
                boilerSequenceDetails.SequenceDescription = "Pre-Purge phase completed";
                LogManager log = new LogManager();
                log.SequenceDetails.Add(boilerSequenceDetails);
            }
        }
        public void IgnitionPhase()
        {
            lock (InterLock)
            {
                DateTime dateTime = DateTime.Now;
                System.Timers.Timer timer = new System.Timers.Timer(100000);
                timer.Start();
                SystemStatus = "Ignition";
                // Console.WriteLine($"{timer.ToString}");
                timer.Stop();
                BoilerSequenceDetails boilerSequenceDetails = new();
                boilerSequenceDetails.Time = dateTime;
                boilerSequenceDetails.SequenceDescription = "Ignition Phase Completed";
                LogManager log = new LogManager();
                log.SequenceDetails.Add(boilerSequenceDetails);
            }

        }
        public void OperationalPhase()
        {
            lock (InterLock)
            {
                DateTime dateTime = DateTime.Now;
                System.Timers.Timer timer = new System.Timers.Timer();
                timer.Start();
                SystemStatus = "Operational";
                timer.Stop();
                BoilerSequenceDetails boilerSequenceDetails = new();
                boilerSequenceDetails.Time = dateTime;
                boilerSequenceDetails.SequenceDescription = "Operational Phase Completed";
                LogManager log = new LogManager();
                log.SequenceDetails.Add(boilerSequenceDetails);
            }
        }

        public void Toggle()
        {
            lock (InterLock)
            {
                DateTime dateTime = DateTime.Now;
                Switch = !Switch;
                LogManager logManager = new LogManager();
                Log log = new Log();
                string message = "InterLock Switch Toggled To" + Switch + " " + dateTime;
                if (message is not null)
                {
                    log.LogMessage = message;
                    logManager.logs.Add(log);
                }
            }
        }

        public void Reset()
        {
            SystemStatus = "LockedDown";
            Switch = false;
        }
    }
}
