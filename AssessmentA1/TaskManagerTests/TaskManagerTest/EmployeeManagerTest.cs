using TaskManager;
namespace TaskManagerTest
{
    public class EmployeeManagerTest
    {
        [Fact]
        public void ValidInputGiven_AddEmployeeDetails_UpdatesList()
        {
            Employee employee = new Employee(24005,"Ancy Jenisha", 8D, "C#", "Yes");
            EmployeeManager employeeManager = new();
            employeeManager.AddEmployeeDetails(employee);
            Assert.Equal(3,employeeManager.Employees.Count);
        }
    }
}