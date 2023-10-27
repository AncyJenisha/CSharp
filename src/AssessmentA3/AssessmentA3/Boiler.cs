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

        public async void BoilerSequence()
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
                System.Timers.Timer timer = new System.Timers.Timer(10000);
                timer.Start();
                SystemStatus = "Pre-Purge";
                Task.Delay(1000);
                timer.Stop();
                BoilerSequenceDetails boilerSequenceDetails = new();
                boilerSequenceDetails.Time = dateTime;
                boilerSequenceDetails.SequenceDescription = "Pre-Purge phase completed";
                Log log = new Log();
                log.SequenceDetails.Add(boilerSequenceDetails);
            }
        }
        public void IgnitionPhase()
        {
            lock (InterLock)
            {
                DateTime dateTime = DateTime.Now;
                System.Timers.Timer timer = new System.Timers.Timer(10000);
                timer.Start();
                SystemStatus = "Ignition";
                // Console.WriteLine($"{timer.ToString}");
                Task.Delay(1000);
                BoilerSequenceDetails boilerSequenceDetails = new();
                boilerSequenceDetails.Time = dateTime;
                boilerSequenceDetails.SequenceDescription = "Ignition Phase Completed";
                Log log = new Log();
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
                BoilerSequenceDetails boilerSequenceDetails = new();
                boilerSequenceDetails.Time = dateTime;
                boilerSequenceDetails.SequenceDescription = "Operational Phase Completed";
                Log log = new Log();
                log.SequenceDetails.Add(boilerSequenceDetails);
            }
        }

        public void Toggle()
        {
            lock (InterLock)
            {
                DateTime dateTime = DateTime.Now;
                Switch = !Switch;

            }
        }
    }
}
