using System.Transactions;

namespace AssessmentA3
{
    public class InputValidators
    {
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