using System.Transactions;

namespace DataAcquisitionSystem
{
    public class ComplianceSetter
    {
        public List<ComplianceData> ComplianceDataOfAllParameters {  get; set; } = new List<ComplianceData>();

        public void GetComplianceData()
        {
            InputValidators InputValidators = new InputValidators();

            Console.WriteLine("Enter the parameter");
            string parameterName = InputValidators.GetStringInput();
            Console.WriteLine("Enter the maximum Value");
            int maximumValue = InputValidators.GetIntegerInput();
            Console.WriteLine("Enter the minimum Value");
            int minimumValue = InputValidators.GetIntegerInput();
            ComplianceData complianceData = new (parameterName, maximumValue, minimumValue);
            ComplianceDataOfAllParameters.Add(complianceData);
        }
    }
}