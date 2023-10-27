namespace AssessmentA3Test
{
    using AssessmentA3;
    public class UnitTest1
    {
        [Fact]
        public void WhenCalled_BoilerSequence_ChangesState()
        {
            Boiler boiler = new Boiler("LockOut");
            boiler.BoilerSequence();
            Assert.True(boiler.SystemStatus == "LockOut");

        }
    }
}