namespace DataAcquisitionSystem
{
    /// <summary>
    /// Program - program class has the main method .
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main - Gets the choice of operation from user and calls the method.
        /// </summary>
        private static void Main()
        {
            int choiceOfOperation;
            InputValidators inputValidators = new InputValidators();
            ConfigureData configureData = new ConfigureData();
            GeneratedValue generatedValue = new GeneratedValue();
            Logger logger = new Logger();
            ConfigureParameter configureParameter = new ConfigureParameter();
            DataAcquisitior dataAcquisitior = new DataAcquisitior( generatedValue, configureData);
            ComplianceSetter complianceSetter = new ComplianceSetter(inputValidators, dataAcquisitior);
            ComplianceChecker complianceChecker = new ComplianceChecker(logger);
            ConfigurationInitializer configurationInitializer = new ConfigurationInitializer(configureData, inputValidators, configureParameter);
            Timer timer = new Timer(dataAcquisitior,configureParameter, complianceChecker, generatedValue, complianceSetter);

            do
            {
                Console.WriteLine("Choose the operation to be performed:\n1.Start Generating Data\n2.Stop Generating Data\n3.Set compliance Data\n4.Refresh Configuration\n5.Exit");
                choiceOfOperation = inputValidators.GetIntegerInput();
                switch (choiceOfOperation)
                {
                    case (int)Options.StartDataAcquisition:
                        dataAcquisitior.GetConfigurationLimits();
                        timer.SetTimer(dataAcquisitior.timeperiod);
                        break;
                    case (int)Options.StopDataAcquisition:
                        Timer.TimerForEvent.Stop();
                        Timer.TimerForEvent.Dispose();
                        break;
                    case (int)Options.SetComplianceDataValue:
                        complianceSetter.GetComplianceData();
                        break;
                    case (int)Options.RefreshConfigurationSettings:
                        configurationInitializer.SetConfiguration();
                        dataAcquisitior.GetConfigurationLimits();
                        Timer.TimerForEvent.Stop();
                        Timer.TimerForEvent.Dispose();
                        dataAcquisitior.GetConfigurationLimits();
                        timer.SetTimer(dataAcquisitior.timeperiod);
                        break;
                    case (int)Options.Exit:
                        break;
                    default:
                        Console.WriteLine("Choose a valid option\n");
                        break;
                }
            }
            while (choiceOfOperation != 5);
        }
    }
}