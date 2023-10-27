namespace AssessmentA3
{
    internal class Program
    {
        static void Main()
        {
            int choiceOfMenu;
            InputValidators inputValidators = new InputValidators();
            LogManager logManager = new LogManager();
            Boiler boiler = new Boiler("LockOut");
            do
            {
                Console.WriteLine("1.Start the Boiler\n2.Stop the Boiler\n3.Simulate Boiler Error\n4.Toggle Switch\n5.Display Details\n");
                choiceOfMenu = inputValidators.GetIntegerInput();
                switch (choiceOfMenu)
                {
                    case (int)MenuOptions.Start:
                        Console.WriteLine("Boiler Controller Initialized");
                        boiler.BoilerSequence();
                        break;

                    case (int)MenuOptions.Stop:
                        boiler.Switch = true;
                        break;

                    case (int)MenuOptions.SimulateBoilerError:
                        Console.WriteLine();
                        break;

                    case (int)MenuOptions.ToggleRunInterLockSwitch:
                        boiler.Toggle();
                        break;
                    case (int)MenuOptions.Display:
                        logManager.DisplayLogs();
                        logManager.DisplaySequenceDetails();
                        break;

                    case (int)MenuOptions.Exit:
                        break;

                    default:
                        Console.WriteLine("Enter a valid option");
                        break;
                }
            }
            while (choiceOfMenu !=5);
        }    
    }
}