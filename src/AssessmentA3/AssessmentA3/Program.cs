﻿namespace AssessmentA3
{
    /// <summary>
    /// Program class has the main method which is the entry of the program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method displays the menu and gets the choice of operation from user.
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Boiler Controller Initialized");

            int choiceOfMenu;
            InputValidators inputValidators = new InputValidators();
            LogManager logManager = new LogManager();
            Boiler boiler = new Boiler(SystemState.LockOut);
            do
            {
                Console.WriteLine("1.Toggle Switch\n2.Reset the boiler\n3.Start the Boiler\n4.Stop the Boiler\n5.Simulate Boiler Error\n6.Display Details\n7.Exit\n");
                choiceOfMenu = inputValidators.GetIntegerInput();
                switch (choiceOfMenu)
                {
                    case (int)MenuOptions.ToggleRunInterLockSwitch:
                        boiler.Toggle();
                        break;

                    case (int)MenuOptions.ResetLockOut:
                        boiler.Reset();
                        break;

                    case (int)MenuOptions.Start:
                        boiler.BoilerSequence();
                        break;

                    case (int)MenuOptions.Stop:
                        boiler.StopBoilerSequence();
                        break;

                    case (int)MenuOptions.SimulateBoilerError:
                        boiler.SimulateBoilerError();
                        break;

                    case (int)MenuOptions.Display:
                        logManager.DisplayLogs();
                        break;

                    case (int)MenuOptions.Exit:
                        break;

                    default:
                        Console.WriteLine("Enter a valid option");
                        break;
                }
            }
            while (choiceOfMenu !=7);
        }    
    }
}