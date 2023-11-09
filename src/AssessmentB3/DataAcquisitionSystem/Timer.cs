using System.Timers;

namespace DataAcquisitionSystem
{
    /// <summary>
    /// Timer - Timer has properties and methods to execute the method by the rate.
    /// </summary>
    public class Timer
    {
        /// <summary>
        /// Gets or sets the object for DataAcquisitior class.
        /// </summary>
        public DataAcquisitior DataAcquisitior { get; set; }

        /// <summary>
        /// Gets or sets the object for ConfigureParameter class.
        /// </summary>
        public ConfigureParameter ConfigureParameter { get; set; }

        /// <summary>
        /// Gets or sets the object for ComplianceSetter.
        /// </summary>
        public ComplianceSetter ComplianceSetter { get; set; }

        /// <summary>
        /// Gets or sets the object for the complianceChecker
        /// </summary>
        public ComplianceChecker ComplianceChecker { get; set; }

        /// <summary>
        /// Gets or sets the List of objects for the GenerateValue class.
        /// </summary>
        public List<GeneratedValue> GeneratedValues { get; set; } = new List<GeneratedValue>();

        /// <summary>
        /// Gets and assigns the parameters to the properties.
        /// </summary>
        /// <param name="dataAcquisitior">Object for DataAcquisitior class</param>
        /// <param name="configureParameter">Object for ConfigureParameter class</param>
        /// <param name="complianceChecker">Object for ComplianceChecker class</param>
        /// <param name="generatedValue">Object for GenerateValue class</param>
        /// <param name="complianceSetter">Object for ComplianceSetter class</param>
        public Timer(DataAcquisitior dataAcquisitior,ConfigureParameter configureParameter ,ComplianceChecker complianceChecker, GeneratedValue generatedValue, ComplianceSetter complianceSetter)
        {
            DataAcquisitior = dataAcquisitior;
            ComplianceChecker = complianceChecker;
            ComplianceSetter = complianceSetter;
            ConfigureParameter = configureParameter;
        }

        /// <summary>
        /// Object for the Timer class.
        /// </summary>
        public static System.Timers.Timer TimerForEvent;

        /// <summary>
        /// SetTimer - Sets the Timer and calls the method on time interval.
        /// </summary>
        /// <param name="timeInterval"></param>
        public async void SetTimer(long timeInterval)
        {
            if(ComplianceSetter.ComplianceDataOfAllParameters.Count == 0)
            {
                Console.WriteLine("Set the compliance value\n");
                return;
            }
            TimerForEvent = new System.Timers.Timer(timeInterval);
            TimerForEvent.Elapsed += OnTimedEvent;
            TimerForEvent.Enabled = true;
            TimerForEvent.AutoReset = true;
        }

        /// <summary>
        /// The method to be invoked by the timer.
        /// </summary>
        /// <param name="source">Object for the source</param>
        /// <param name="e">Data for the event</param>
        public async void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            // To generate data within the configured Value

            Random random = new Random();

            foreach (var parameterLimit in DataAcquisitior.ConfigureParameters)
            {
                GeneratedValue generatedValue = new GeneratedValue();
                generatedValue.Parameter = parameterLimit.ParameterName;
                generatedValue.Value = random.Next(parameterLimit.MinimumValue, parameterLimit.MaximumValue);
                GeneratedValues.Add(generatedValue);
            }
            ComplianceChecker.CheckCompliance(GeneratedValues, ComplianceSetter.ComplianceDataOfAllParameters);
        }
    }
}