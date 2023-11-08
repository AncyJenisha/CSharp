using System.Reflection.Metadata.Ecma335;
using System.Threading;
using System.Timers;

namespace DataAcquisitionSystem
{
    public class Timer
    {
        public DataAcquisitior DataAcquisitior { get; set; }

        public ConfigureParameter ConfigureParameter { get; set; }

        public ComplianceSetter ComplianceSetter { get; set; }

        public ComplianceChecker ComplianceChecker { get; set; }

        public List<GeneratedValue> GeneratedValues { get; set; } = new List<GeneratedValue>();
        public Timer(DataAcquisitior dataAcquisitior,ConfigureParameter configureParameter ,ComplianceChecker complianceChecker, GeneratedValue generatedValue, ComplianceSetter complianceSetter)
        {
            DataAcquisitior = dataAcquisitior;
            ComplianceChecker = complianceChecker;
            ComplianceSetter = complianceSetter;
            ConfigureParameter = configureParameter;
        }

        public static System.Timers.Timer TimerForEvent;

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

        public async void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            bool check = true;
            // To generate data within the configured Value

            Random random = new Random();

            foreach (var parameterLimit in DataAcquisitior.ConfigureParameters)
            {
                GeneratedValue generatedValue = new GeneratedValue();
                generatedValue.Parameter = parameterLimit.ParameterName;
                generatedValue.Value = random.Next(parameterLimit.MinimumValue, parameterLimit.MaximumValue);
                GeneratedValues.Add(generatedValue);
            }
            ComplianceChecker.CheckCompliance(GeneratedValues, ComplianceSetter.ComplianceDataOfAllParameters, check);
        }
    }
}