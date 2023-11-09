namespace DataAcquisitionSystem
{
    /// <summary>
    /// Options - Has different options for console menu.
    /// </summary>
    public enum Options
    {
        /// <summary>
        /// calls the generate data from the DataAcquisition class.
        /// </summary>
        StartDataAcquisition = 1,

        /// <summary>
        /// Unsubscribes the method to generate data.
        /// </summary>
        StopDataAcquisition,

        /// <summary>
        /// Calls mthod to set the compliance data value
        /// </summary>
        SetComplianceDataValue,

        /// <summary>
        /// Calls the method to get the configure data.
        /// </summary>
        RefreshConfigurationSettings,

        /// <summary>
        /// Exits the program.
        /// </summary>
        Exit,
    }
}