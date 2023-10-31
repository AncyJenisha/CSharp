namespace AssessmentA3
{
    using System.Security.Cryptography.X509Certificates;
    using System.Timers;

    public class Boiler
    {
        public bool Switch = false;

        private Timer? processTimer;

        public string? SystemStatus { get; set; }

        public Boiler(string initialStatus)
        {
            SystemStatus = initialStatus;
            Switch = false;
            LogManager logger = new();
            BoilerSequenceDetails boilerSequenceDetails = new();
            boilerSequenceDetails.Time = DateTime.Now;
            boilerSequenceDetails.EventData = "Boiler initialized";
            boilerSequenceDetails.Event = SystemStatus;

            using (StreamWriter streamWriter = File.AppendText("Log.txt"))
            {
                logger.LogToFile(boilerSequenceDetails, streamWriter);
            }
        }

        public void BoilerSequence()
        {
            if (Switch && SystemStatus == "Ready")
            {
                PrePurgePhase();
                IgnitionPhase();
                OperationalPhase();
            }
            else if(!Switch)
            {
                Console.WriteLine("Switch is opened, toggle it to start boiler\n\n");
            }
            else
            {
                Console.WriteLine("Reset the boiler to get to ready state");
            }
        }

        public void PrePurgePhase()
        {
            if (Switch)
            {
                SystemStatus = "Pre-Purge";
                Console.WriteLine("In Pre-Purge Phase");

                TimerImplementer timer = new TimerImplementer();
                timer.SetTimer(10000);

                BoilerSequenceDetails boilerSequenceDetails = new();
                boilerSequenceDetails.Time = DateTime.Now;
                boilerSequenceDetails.Event = SystemStatus;
                boilerSequenceDetails.EventData = "Pre-Purge phase completed";

                LogManager log = new LogManager();

                using (StreamWriter streamWriter = File.AppendText("Log.txt"))
                {
                    log.LogToFile(boilerSequenceDetails, streamWriter);
                }

            }
        }


        public void IgnitionPhase()
        {
            if (Switch)
            {
                SystemStatus = "Ignition Phase";
                Console.WriteLine("In Ignition Phase");

                TimerImplementer timer = new TimerImplementer();
                timer.SetTimer(10000);

                BoilerSequenceDetails boilerSequenceDetails = new();
                boilerSequenceDetails.Time = DateTime.Now;
                boilerSequenceDetails.Event = SystemStatus;
                boilerSequenceDetails.EventData = "Pre-Purge phase completed";

                LogManager log = new LogManager();

                using (StreamWriter streamWriter = File.AppendText("Log.txt"))
                {
                    log.LogToFile(boilerSequenceDetails, streamWriter);
                }

            }
        }


        public void OperationalPhase()
        {
            if (Switch)
            {
                SystemStatus = "Operational";
                Console.WriteLine("In operational Phase");

                TimerImplementer timer = new TimerImplementer();
                timer.SetTimer(10000);

                BoilerSequenceDetails boilerSequenceDetails = new();
                boilerSequenceDetails.Time = DateTime.Now;
                boilerSequenceDetails.EventData = "Boiler now Operational";
                boilerSequenceDetails.Event = SystemStatus;

                LogManager log = new LogManager();

                using (StreamWriter streamWriter = File.AppendText("Log.txt"))
                {
                    log.LogToFile(boilerSequenceDetails, streamWriter);
                }
            }

        }

        public void Toggle()
        {
            Switch = !Switch;

            LogManager logManager = new LogManager();
            BoilerSequenceDetails boilerSequenceDetails = new();
            boilerSequenceDetails.Time = DateTime.Now;
            boilerSequenceDetails.EventData = "InterLock Switch Toggled To" + Switch;
            boilerSequenceDetails.Event = SystemStatus;

            if (boilerSequenceDetails is not null)
            {

                LogManager logger = new();

                using (StreamWriter streamWriter = File.AppendText("Log.txt"))
                {
                    logger.LogToFile(boilerSequenceDetails, streamWriter);
                }
            }

            Console.WriteLine("Switch Toggled\n\n");
        }

        public void Reset()
        {
            if (!Switch)
            {
                Console.WriteLine("Close the interlock");
            }
            else
            {
                SystemStatus = "Ready";
                LogManager logger = new();
                BoilerSequenceDetails boilerSequenceDetails = new();
                boilerSequenceDetails.Time = DateTime.Now;
                boilerSequenceDetails.EventData = "Boiler is reset";
                boilerSequenceDetails.Event = SystemStatus;

                using (StreamWriter streamWriter = File.AppendText("Log.txt"))
                {
                    logger.LogToFile(boilerSequenceDetails, streamWriter);
                }

            }
        }

        public void SimulateBoilerError()
        {
            if(SystemStatus == "Operational")
            {
                Switch = false;
                SystemStatus = "Error";

                LogManager logger = new();
                BoilerSequenceDetails boilerSequenceDetails = new();
                boilerSequenceDetails.Time = DateTime.Now;
                boilerSequenceDetails.EventData = "Boiler faced an error and went to LockOut state";
                boilerSequenceDetails.Event = SystemStatus;

                using (StreamWriter streamWriter = File.AppendText("Log.txt"))
                {
                    logger.LogToFile(boilerSequenceDetails, streamWriter);
                }

                SystemStatus = "LockOut";
                Console.WriteLine("Boiler faced an error");
            }
            else
            {
                Console.WriteLine("Boiler is not in operational state");
            }
            
        }

        public void StopBoilerSequence()
        {
            if(SystemStatus == "Operational")
            {
                Switch = false;
                SystemStatus = "LockOut";

                LogManager logger = new();
                BoilerSequenceDetails boilerSequenceDetails = new();
                boilerSequenceDetails.Time = DateTime.Now;
                boilerSequenceDetails.EventData = "Boiler Operation is stopped";
                boilerSequenceDetails.Event = SystemStatus;

                using (StreamWriter streamWriter = File.AppendText("Log.txt"))
                {
                    logger.LogToFile(boilerSequenceDetails, streamWriter);
                }

                Console.WriteLine("Boiler stopped");
            }
            else
            {
                Console.WriteLine("Boiler is not in operational phase");
            }
        }
    }
}
