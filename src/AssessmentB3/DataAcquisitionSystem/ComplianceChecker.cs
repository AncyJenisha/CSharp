namespace DataAcquisitionSystem
{
    public class ComplianceChecker
    {
        public void CheckCompliance(GeneratedValue generatedValue , List<ComplianceData> checkdata)
        {
            // To Check The compliance of the generated values.

            foreach (ComplianceData complianceData in checkdata)
            {
                if (complianceData.Parameter == generatedValue.Parameter)
                {
                    if(generatedValue.Value <= complianceData.MaximumValue && generatedValue.Value >= complianceData.MaximumValue)
                    {
                        Logger logger = new ($"{generatedValue.Parameter} : {generatedValue.Value}  Compliance Successful");

                    }
                    else
                    {
                        Logger logger = new ($"{generatedValue.Parameter} : {generatedValue.Value}  Compliance Failed");

                    }
                }
            }
        }
    }
}