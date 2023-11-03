namespace DataAcquisitionSystem
{
    internal class Program
    {
        static void Main()
        {
            ConfigurationInitializer configurationInitializer = new ConfigurationInitializer();
            configurationInitializer.SetConfiguration();
        }
    }
}