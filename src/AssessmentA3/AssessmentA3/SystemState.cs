namespace AssessmentA3
{
    /// <summary>
    /// SystemState - The different states of the boiler.
    /// </summary>
    public enum SystemState
    {
        LockOut =1,

        Ready,

        PrePurge,

        Ignition,

        Operational,

        Error,

    }
}