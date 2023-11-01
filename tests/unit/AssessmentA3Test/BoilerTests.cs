namespace AssessmentA3Test
{
    using AssessmentA3;
    public class BoilerTests
    {

        [Fact]
        public void WhenCalled_OperationalPhase_ChangesState()
        {
            Boiler boiler = new Boiler(SystemState.LockOut);
            boiler.OperationalPhase();

            SystemState actual = boiler.SystemStatus;

            Assert.Equal(SystemState.Operational, actual);
        }

        [Fact]
        public void WhenCalled_Toggle_BecomesTrue()
        {
            Boiler boiler = new Boiler(SystemState.LockOut);
            boiler.Toggle();

            bool actual = boiler.Switch;

            Assert.True(actual);
        }

        [Fact]
        public void WhenCalled_SimulateBoilerError_StatusChanges()
        {
            Boiler boiler = new Boiler(SystemState.LockOut);
            boiler.SystemStatus = SystemState.Operational;
            boiler.SimulateBoilerError();

            SystemState actual = boiler.SystemStatus;

            Assert.Equal(SystemState.Error, actual);
        }

        [Fact]
        public void WhenCalled_Reset_StatusChanges()
        {
            Boiler boiler = new Boiler(SystemState.LockOut);
            boiler.Switch = true;
            boiler.Reset();

            SystemState actual = boiler.SystemStatus;

            Assert.Equal(SystemState.Ready, actual);
        }

        [Fact]
        public void WhenCalled_StopBoilerSequence_StatusChanges()
        {
            Boiler boiler = new Boiler(SystemState.LockOut);
            boiler.SystemStatus = SystemState.Operational;
            boiler.StopBoilerSequence();

            SystemState actual = boiler.SystemStatus;

            Assert.Equal(SystemState.LockOut, actual);
        }
    }
}