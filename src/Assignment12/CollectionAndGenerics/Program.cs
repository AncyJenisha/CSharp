// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace CollectionAndGenerics
{
    using ValidatorsApp;

    /// <summary>
    /// Program class has the main method which gets user choice.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Gets or sets elements to the Generic Queue.
        /// </summary>
        /// <value>Has names as string</value>
        public static GenericQueue<string> Names { get; set; } = new ();

        /// <summary>
        /// Gets or sets the generic type elements for the Stack.
        /// </summary>
        /// <value>Generic type elements.</value>
        public static GenericStack<char> CharactersObject { get; set; } = new ();

        /// <summary>
        /// Gets or sets the Generic type elements for the list.
        /// </summary>
        /// <value>Generic type elements.</value>
        public static GenericList<string> ListObj { get; set; } = new ();

        /// <summary>
        /// Gets or sets values for acessing the generic Dictionary.
        /// </summary>
        /// <value>Student name as string and grade as float.</value>
        public static GenericDictionary<string, float> StudentDetailsObject { get; set; } = new ();

        /// <summary>
        /// Main method gets the options for the collection types.
        /// </summary>
        private static void Main()
        {
            int choiceOfListOperation;
            int choiceOfStackOperation;
            int choiceOfQueueOperation;
            int choiceOfDictionaryOperation;
            List<int> listOfNumbers = new ();
            Queue<int> queueOfNumbers = new ();
            Stack<int> stackOfNumbers = new ();
            Dictionary<int, string> employeeDetails = new ();
            Console.WriteLine("\nChoose the type of Collection:\n1.List\n2.Stack\n3.Queue\n4.Dictionary\n");
            int choiceOfCollection = InputValidators.GetIntegerInput();
            switch (choiceOfCollection)
            {
                case (int)TypeofCollections.List:
                    do
                    {
                        Console.WriteLine("\nChoose the Operation:\n1.Add Books\n2.Delete Books\n3.Display BookList\n4.Exit\n");
                        choiceOfListOperation = InputValidators.GetIntegerInput();
                        switch (choiceOfListOperation)
                        {
                            case (int)ListOperations.AddBook:
                                ListofBooks.AddBooks();
                                break;
                            case (int)ListOperations.DisplayBookList:
                                ListObj.DisplayBookList();
                                break;
                            case (int)ListOperations.DeleteBook:
                                ListofBooks.RemoveBooks();
                                break;
                            case (int)ListOperations.Exit:
                                break;
                            default:
                                Console.WriteLine("Choose a valid option");
                                break;
                        }
                    }
                    while (choiceOfListOperation != 4);
                    break;

                case (int)TypeofCollections.Stack:
                    do
                    {
                        Console.WriteLine("\nChoose the Operation:\n1.Push a Character\n2.Pop a Character\n3.Display the Stack\n4.Exit");
                        choiceOfStackOperation = InputValidators.GetIntegerInput();
                        switch (choiceOfStackOperation)
                        {
                            case (int)StackOperations.PushStack:
                                StackOfCharacters.PushCharacterToStack();
                                break;
                            case (int)StackOperations.PopStack:
                                StackOfCharacters.PopCharacterToStack();
                                break;
                            case (int)StackOperations.DisplayStack:
                                CharactersObject.DisplayCharacters();
                                break;
                            case (int)StackOperations.Exit:
                                break;
                            default:
                                Console.WriteLine("Choose a valid option\n");
                                break;
                        }
                    }
                    while (choiceOfStackOperation != 4);
                    break;

                case (int)TypeofCollections.Queue:
                    do
                    {
                        Console.WriteLine("\nChoose the Operation:\n1.Enqueue\n2.Dequeue\n3.Display\n4.Exit");
                        choiceOfQueueOperation = InputValidators.GetIntegerInput();
                        switch (choiceOfQueueOperation)
                        {
                            case (int)QueueOperations.AddQueue:
                                Queue.EnqueueNames();
                                break;
                            case (int)QueueOperations.DisplayQueue:
                                Names.DisplayNames();
                                break;
                            case (int)QueueOperations.DeleteQueue:
                                Queue.DequeueNames();
                                break;
                            case (int)QueueOperations.Exit:
                                break;
                            default:
                                Console.WriteLine("Enter a valid Option\n");
                                break;
                        }
                    }
                    while (choiceOfQueueOperation != 4);
                    break;

                case (int)TypeofCollections.Dictionary:
                    do
                    {
                        Console.WriteLine("\nChoose the Operation:\n1.Add Dictionary element\n2.Display Dictionary element\n3.Delete Dictionary element\n4.Exit\n");
                        choiceOfDictionaryOperation = InputValidators.GetIntegerInput();
                        switch (choiceOfDictionaryOperation)
                        {
                            case (int)DictionaryOperations.AddGrades:
                                DictionaryofStudentDetails.AddDetails();
                                break;
                            case (int)DictionaryOperations.DisplayGrades:
                                StudentDetailsObject.DisplayStudentDetails();
                                break;
                            case (int)DictionaryOperations.DeleteGrades:
                                DictionaryofStudentDetails.RemoveDetails();
                                break;
                            case (int)DictionaryOperations.Exit:
                                break;
                            default:
                                Console.WriteLine("Choose the correct option\n");
                                break;
                        }
                    }
                    while (choiceOfDictionaryOperation != 4);
                    break;
            }

            Console.WriteLine("Check Sum of the collection");
            Console.WriteLine("Choose the collection Type:\n 1.List 2.Queue 3.Stack 4.Exit");
            int typeOfCollectionForSum = InputValidators.GetIntegerInput();
            switch (typeOfCollectionForSum)
            {
                case (int)TypeOfCollectionForSum.List:
                    Console.WriteLine("Enter the integers:");
                    for (int i = 0; i < 5; i++)
                    {
                        int numberToBeAddedToList = InputValidators.GetIntegerInput();
                        listOfNumbers.Add(numberToBeAddedToList);
                    }

                    Console.WriteLine($"Sum:{SumCalculator.SumOfElementsofCollection(listOfNumbers)}");
                    break;

                case (int)TypeOfCollectionForSum.Queue:
                    Console.WriteLine("Enter the integers:");
                    for (int i = 0; i < 5; i++)
                    {
                        int numberToBeAddedToQueue = InputValidators.GetIntegerInput();
                        queueOfNumbers.Enqueue(numberToBeAddedToQueue);
                    }

                    Console.WriteLine($"Sum:{SumCalculator.SumOfElementsofCollection(queueOfNumbers)}");
                    break;

                case (int)TypeOfCollectionForSum.Stack:
                    Console.WriteLine("Enter the integers:");
                    for (int i = 0; i < 5; i++)
                    {
                        int numberToBeAddedToStack = InputValidators.GetIntegerInput();
                        stackOfNumbers.Push(numberToBeAddedToStack);
                    }

                    Console.WriteLine($"Sum:{SumCalculator.SumOfElementsofCollection(stackOfNumbers)}");
                    break;

                case (int)TypeofCollections.Exit:
                    break;

                default:
                    Console.WriteLine("Choose a valid option");
                    break;
            }

            Console.WriteLine("Create a ReadOnlyDictionary");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the id:");
                int idNumber = InputValidators.GetIntegerInput();
                Console.WriteLine("Enter the name:");
                string nameOfEmployee = InputValidators.GetStringInput();
                employeeDetails.Add(idNumber, nameOfEmployee);
            }

            var readOnlyDictionaryOfEmployeeDetails = DictionaryGenerator.CreateDictionary(employeeDetails);
            foreach (var kvp in readOnlyDictionaryOfEmployeeDetails)
            {
                Console.WriteLine($"Employee Id:{kvp.Key} Employee Name:{kvp.Value}");
            }
        }
    }
}
