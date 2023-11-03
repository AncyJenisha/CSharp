namespace DataAcquisitionSystem
{
    public class InputValidators
    {
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