namespace AssessmentA3
{
    public class Boiler
        {
            public readonly object Lockout = new object();

            public List<BoilerSequenceDetails> SequenceDetails;

            public string SystemStatus { get; set; } = "LockOut";

            public Boiler(string initialStatus)
            {
                SystemStatus = initialStatus;
            }

            public void BoilerSequence()
            {
                lock (Lockout)
                {
                    PrePurgePhase();
                    IgnitionPhase();
                    OperationalPhase();
                }
            }
            public void PrePurgePhase()
            {
                lock (Lockout)
                {
                    DateTime dateTime = DateTime.Now;
                    System.Timers.Timer timer = new System.Timers.Timer(10000);
                    timer.Start();
                    SystemStatus = "Pre-Purge";
                    timer.Stop();
                    BoilerSequenceDetails boilerSequenceDetails = new("Pre-Purge Completed", dateTime);
                    SequenceDetails.Add(boilerSequenceDetails);
                }
            }
            public void IgnitionPhase()
            {
                DateTime dateTime = DateTime.Now;
                System.Timers.Timer timer = new System.Timers.Timer(10000);
                timer.Start();
                SystemStatus = "Ignition";
                timer.Stop();
                BoilerSequenceDetails boilerSequenceDetails = new("Ignition Phase Completed", dateTime);
                SequenceDetails.Add(boilerSequenceDetails);
            }
            public void OperationalPhase()
            {
                DateTime dateTime = DateTime.Now;
                System.Timers.Timer timer = new System.Timers.Timer(10000);
                timer.Start();
                SystemStatus = "Operational";
                timer.Stop();
                BoilerSequenceDetails boilerSequenceDetails = new("Operational Phase Completed", dateTime);
                SequenceDetails.Add(boilerSequenceDetails);
            }
        }
    }
}