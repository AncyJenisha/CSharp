using DataAcquisitionSystem;
using Moq;

namespace DataAcquisitiorBTest
{
    public class ComplianceCheckerTest
    {
        [Fact]
        public void ValidListGiven_ComplianceChecker_WritesToFile()
        {
            GeneratedValue generatedValue = new GeneratedValue();
            Logger logger = new Logger();
            ComplianceData complianceData = new ComplianceData("Current", 100, 25);         
            generatedValue.Value = 50;
            generatedValue.Parameter = "Current";

            ComplianceChecker complianceChecker = new ComplianceChecker(logger);

            Assert.True(complianceChecker.LogComplianceCheck(complianceData, generatedValue));
        }
    }
}