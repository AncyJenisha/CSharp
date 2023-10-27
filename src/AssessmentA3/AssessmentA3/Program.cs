namespace AssessmentA3
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            InputValidators inputValidators = new InputValidators();
            Boiler boiler = new Boiler("LockOut");
            Console.WriteLine("Start the Boiler\n2.Stop the Boiler\n3.Simulate Boiler Error\n");
            int choiceOfMenu = inputValidators.GetIntegerInput();
            switch(choiceOfMenu)
            {
                case (int)MenuOptions.Start:
                    Console.WriteLine("Boiler Controller Initialized");
                    boiler.Switch = false;
                    boiler.BoilerSequence();
                    break;

                case (int)MenuOptions.Stop:
                    boiler.Switch= true;
                    break;

                case (int)MenuOptions.SimulateBoilerError:
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }
           
        }
    }
}