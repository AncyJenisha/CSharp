using System.Transactions;

namespace AssessmentA3
{
    /// <summary>
    /// InputValidators - Has method to validate input enterd by user.
    /// </summary>
    public class InputValidators
    {
        /// <summary>
        /// Read and parse string input to integer.
        /// </summary>
        /// <returns></returns>
        public int GetIntegerInput()
        {
            int number;
            string? inputRead = Console.ReadLine();
            while (!int.TryParse(inputRead, out number))
            {
                Console.WriteLine("Enter a valid Number");
                inputRead = Console.ReadLine();
            }
            return number;
        }

    }
}