using System.Transactions;

namespace DataAcquisitionSystem
{
    public class ComplianceSetter
    {
        List<ComplianceData> ComplianceDataOfAllParameters {  get; set; } = new List<ComplianceData>();

        public void GetComplianceData()
        {
            InputValidators InputValidators = new InputValidators();

            Console.WriteLine("Enter the parameter");
            string parameterName = InputValidators.GetStringInput();
            Console.WriteLine("Enter the maximum value");
            double maximumValue = InputValidators.GetDoubleInput();
            Console.WriteLine("Enter the minimum value");
            double minimumValue = InputValidators.GetDoubleInput();
            ComplianceData complianceData = new (parameterName, maximumValue, minimumValue);
            ComplianceDataOfAllParameters.Add(complianceData);
        }
    }
}