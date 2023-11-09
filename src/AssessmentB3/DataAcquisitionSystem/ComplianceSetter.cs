using System.Transactions;

namespace DataAcquisitionSystem
{
    /// <summary>
    /// ComplianceSetter - Has methods and properties to set the compliance value.
    /// </summary>
    public class ComplianceSetter
    {
        /// <summary>
        /// Gets or sets the oject for the InputValidator class
        /// </summary>
        public InputValidators InputValidators { get; }

        /// <summary>
        /// Gets or sets the object for the DataAcquisitior class.
        /// </summary>
        public DataAcquisitior DataAcquisitior { get; set; }

        /// <summary>
        /// Gets and assigns the value for the properties.
        /// </summary>
        /// <param name="inputValidators">Object of InputValidators class.</param>
        public ComplianceSetter(InputValidators inputValidators, DataAcquisitior dataAcquisitior)
        {
            InputValidators = inputValidators;
            DataAcquisitior = dataAcquisitior;
        }

        /// <summary>
        /// Gets or sets the ComplianceData objects as list.
        /// </summary>
        public List<ComplianceData> ComplianceDataOfAllParameters { get; set; } = new List<ComplianceData>();

        /// <summary>
        /// GetComplianceData - Gets the ComplianceData value from user.
        /// </summary>
        public void GetComplianceData()
        {
            foreach(var parameter in DataAcquisitior.ConfigureParameters)
            {
                string parameterName = parameter.ParameterName;
                Console.WriteLine($"Enter the maximum Value of {parameterName}");
                int maximumValue = InputValidators.GetIntegerInput();
                Console.WriteLine($"Enter the minimum Value of {parameterName}");
                int minimumValue = InputValidators.GetIntegerInput();
                ComplianceData complianceData = new(parameterName, maximumValue, minimumValue);
                ComplianceDataOfAllParameters.Add(complianceData);
            }
        }
    }
}