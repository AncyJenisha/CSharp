namespace AssessmentA3Test
{
    using AssessmentA3;
    public class BoilerTests
    {
        [Fact]
        public void WhenCalled_BoilerSequence_ChangesState()
        {
            Boiler boiler = new Boiler("LockOut");
            boiler.BoilerSequence();
            string? actual = boiler.SystemStatus;
            Assert.Equal("LockOut",actual);

        }


    }
}