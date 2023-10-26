namespace AdvancedLinq
{
    public class InputValidators
    {
        /// <summary>
        /// This method reads string from user and converts it into integer.
        /// </summary>
        /// <returns>Float number</returns>
        public int GetIntegerInput()
        {
            int number;
            string? inputRead = Console.ReadLine();
            while (!int.TryParse(inputRead, out number))
            {
                Console.WriteLine("Enter valid Number");
                inputRead = Console.ReadLine();
            }

            return number;
        }

        /// <summary>
        /// This method reads string from user and converts it into float.
        /// </summary>
        /// <returns>Float number</returns>
        public float GetFloatInput()
        {
            float number;
            string? inputRead = Console.ReadLine();
            while (!float.TryParse(inputRead, out number))
            {
                Console.WriteLine("Enter valid Number");
                inputRead = Console.ReadLine();
            }

            return number;
        }

        /// <summary>
        /// Gets the string and validates it.
        /// </summary>
        /// <returns>A valid string</returns>
        public string GetStringInput()
        {
            string? inputRead = Console.ReadLine();
            while (string.IsNullOrEmpty(inputRead))
            {
                Console.WriteLine("Enter a valid Input");
                inputRead = Console.ReadLine();
            }

            return inputRead;
        }
    }
}
