namespace DataAcquisitionSystem
{
    public class ComplianceChecker
    {
        public Logger Logger { get; set; }

        public Timer Timer { get; set; }

        public ComplianceChecker(Logger logger)
        {
            Logger = logger;
        }

        public void CheckCompliance(List<GeneratedValue> generatedValue, List<ComplianceData> checkdata, bool check)
        {
            // To Check The compliance of the generated values.

            foreach (ComplianceData complianceData in checkdata)
            {
                foreach (GeneratedValue generated in generatedValue)
                {
                    if (complianceData.Parameter == generated.Parameter)
                    {
                        if (generated.Value < complianceData.MaximumValue && generated.Value > complianceData.MinimumValue)
                        {
                            Logger.LogWrite($"{generated.Parameter} : {generated.Value}  Compliance Successful");
                        }
                        else
                        {
                            Logger.LogWrite($"{generated.Parameter} : {generated.Value}  Compliance Failed");
                        }
                    }
                }
            }

        }
    }
}