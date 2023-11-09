namespace DataAcquisitionSystem
{
    /// <summary>
    /// InputValidator - Has methods to get input from user and validate it.
    /// </summary>
    public class InputValidators
    {
        /// <summary>
        /// GetDoubleInput - Gets the string input from user and parses it to double value
        /// </summary>
        /// <returns>Double number</returns>
        public double GetDoubleInput()
        {
            double number;
            string? inputRead = Console.ReadLine();
            while (!double.TryParse(inputRead, out number))
            {
                Console.WriteLine("Enter a valid number");
                inputRead = Console.ReadLine();
            }

            return number;
        }

        /// <summary>
        /// GetIntegerInput - Gets the string input from uer and parses it to integer.
        /// </summary>
        /// <returns>Integer number</returns>
        public int GetIntegerInput()
        {
            int number;
            string? inputRead = Console.ReadLine();
            while (!int.TryParse(inputRead, out number))
            {
                Console.WriteLine("Enter a valid number");
                inputRead = Console.ReadLine();
            }

            return number;
        }

        /// <summary>
        /// GetStringInput - Gets the string input and validates it for non empty string.
        /// </summary>
        /// <returns>NonEmpty string</returns>
        public string GetStringInput()
        {
            string? inputRead = Console.ReadLine();
            while (string.IsNullOrEmpty(inputRead))
            {
                Console.WriteLine("Enter a valid data");
                inputRead = Console.ReadLine();
            }

            return inputRead;
        }
    }
}