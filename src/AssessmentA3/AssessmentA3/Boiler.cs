namespace AssessmentA3
{
    using System.Security.Cryptography.X509Certificates;
    using System.Timers;

    /// <summary>
    /// Boiler class - Has methods for different phases of the boiler and fields and property describing the state.
    /// </summary>
    public class Boiler
    {
        /// <summary>
        /// The switch has two states for the ready state of boiler.
        /// </summary>
        public bool Switch = false;

        /// <summary>
        /// System Status gets or sets the state of the boiler.
        /// </summary>
        public SystemState SystemStatus { get; set; }

        /// <summary>
        /// Sets the initial values to the fields and property.
        /// </summary>
        /// <param name="initialStatus"></param>
        public Boiler(SystemState initialStatus)
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

        /// <summary>
        /// Boiler Sequence - calls the methods for the operation of phases in sequence.
        /// </summary>
        public void BoilerSequence()
        {
            if (Switch && SystemStatus == SystemState.Ready)
            {
                PrePurgePhase();
                IgnitionPhase();
                OperationalPhase();
            }
            else if (!Switch)
            {
                Console.WriteLine("Switch is opened, toggle it to start boiler\n\n");
            }
            else if (SystemStatus != SystemState.Ready)
            {
                Console.WriteLine("Reset the Boiler to start the operation\n\n");
            }
        }

        /// <summary>
        /// PrePurge - Has the boiler in Pre-Purge state.
        /// </summary>
        public void PrePurgePhase()
        {

            SystemStatus = SystemState.PrePurge;
            Console.WriteLine("In Pre-Purge Phase\n\n");

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

        /// <summary>
        /// IgnitionPhase - Has the boiler in Ignition phase.
        /// </summary>
        public void IgnitionPhase()
        {

            SystemStatus = SystemState.Ignition;
            Console.WriteLine("In Ignition Phase\n\n");

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

        /// <summary>
        /// OperationalPhase - holds the boiler in Operational state.
        /// </summary>
        public void OperationalPhase()
        {

            SystemStatus = SystemState.Operational;
            Console.WriteLine("In operational Phase\n\n");

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

        /// <summary>
        /// Toggle - togggles the switch
        /// </summary>
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

        /// <summary>
        /// Reset - resets the status of the boiler preparing it for the operation sequence.
        /// </summary>
        public void Reset()
        {
            if (!Switch)
            {
                Console.WriteLine("Close the interlock\n\n");
            }
            else
            {
                SystemStatus = SystemState.Ready;
                LogManager logger = new();
                BoilerSequenceDetails boilerSequenceDetails = new();
                boilerSequenceDetails.Time = DateTime.Now;
                boilerSequenceDetails.EventData = "Boiler is reset";
                boilerSequenceDetails.Event = SystemStatus;

                using (StreamWriter streamWriter = File.AppendText("Log.txt"))
                {
                    logger.LogToFile(boilerSequenceDetails, streamWriter);
                }

                Console.WriteLine("Boiler is Ready\n\n");
            }
        }

        /// <summary>
        /// SimulateBoilerError - Simulate an error in the boiler operation if it is in operation state.
        /// </summary>
        public void SimulateBoilerError()
        {
            if (SystemStatus == SystemState.Operational)
            {
                Switch = false;
                SystemStatus = SystemState.Error;

                LogManager logger = new();
                BoilerSequenceDetails boilerSequenceDetails = new();
                boilerSequenceDetails.Time = DateTime.Now;
                boilerSequenceDetails.EventData = "Boiler faced an error and went to LockOut state";
                boilerSequenceDetails.Event = SystemStatus;

                using (StreamWriter streamWriter = File.AppendText("Log.txt"))
                {
                    logger.LogToFile(boilerSequenceDetails, streamWriter);
                }

                SystemStatus = SystemState.Error;
                Console.WriteLine("Boiler faced an error\n\n");
            }
            else
            {
                Console.WriteLine("Boiler is not in operational state\n\n");
            }

        }

        /// <summary>
        /// StopBoilerSequence - stops the boiler operartion if it is in operational state.
        /// </summary>
        public void StopBoilerSequence()
        {
            if (SystemStatus == SystemState.Operational)
            {
                Switch = false;
                SystemStatus = SystemState.LockOut;

                LogManager logger = new();
                BoilerSequenceDetails boilerSequenceDetails = new();
                boilerSequenceDetails.Time = DateTime.Now;
                boilerSequenceDetails.EventData = "Boiler Operation is stopped";
                boilerSequenceDetails.Event = SystemStatus;

                using (StreamWriter streamWriter = File.AppendText("Log.txt"))
                {
                    logger.LogToFile(boilerSequenceDetails, streamWriter);
                }

                Console.WriteLine("Boiler stopped\n\n");
            }
            else
            {
                Console.WriteLine("Boiler is not in operational phase\n\n");
            }
        }
    }
}
