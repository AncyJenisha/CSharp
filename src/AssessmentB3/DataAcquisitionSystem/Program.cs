namespace DataAcquisitionSystem
{
    internal class Program
    {
        private static void Main()
        {
            int choiceOfOperation;
            InputValidators inputValidators = new InputValidators();
            DataAcquisitior dataAcquisitior = new DataAcquisitior();
            ComplianceSetter complianceSetter = new ComplianceSetter();
            ConfigurationInitializer configurationInitializer = new ConfigurationInitializer();
            Timer timer = new Timer();

            Console.WriteLine("Choose the operation to be performed:\n1.Start Generating Data\n2.Stop Generating Data\n3.Set compliance Data\n4.Refresh Configuration\n5.Exit");
            choiceOfOperation = inputValidators.GetIntegerInput();

            switch(choiceOfOperation)
            {
                case (int)Options.StartDataAcquisition:
                    dataAcquisitior.GetConfigurationLimits();
                    dataAcquisitior.GenerateData();
                    break;
                case (int)Options.StopDataAcquisition:
                    break;
                case (int)Options.SetComplianceDataValue:
                    complianceSetter.GetComplianceData();
                    break;
                case (int)Options.RefreshConfigurationSettings:
                    configurationInitializer.SetConfiguration();
                    dataAcquisitior.GetConfigurationLimits();
                    break;
                case (int)Options.Exit:
                    break;
                default:
                    Console.WriteLine("Choose a valid option\n");
                    break;
            }
        }
    }
}