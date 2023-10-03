// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using ValidatorsApp;

namespace CollectionAndGenerics
{
    /// <summary>
    /// Program class has the main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method gets the options for the collection types.
        /// </summary>
        private static void Main()
        {
            int choiceOfListOperation;
            int choiceOfStackOperation;
            int choiceOfQueueOperation;
            int choiceOfDictionaryOperation;
            Console.WriteLine("Choose the type of Collection:\n1.List\n2.Stack\n3.Queue\n4.Dictionary\n");
            int choiceOfCollection = InputValidators.GetIntegerInput();
            switch (choiceOfCollection)
            {
                case (int)TypeofCollections.List:
                    do
                    {
                        Console.WriteLine("Choose the Operation:\n1.Add Books\n2.Delete Books\n3.Display BookList\n4.Exit\n");
                        choiceOfListOperation = InputValidators.GetIntegerInput();
                        switch (choiceOfListOperation)
                        {
                            case (int)ListOperations.AddBook:
                                ListofBooks.AddBooks();
                                break;
                            case (int)ListOperations.DisplayBookList:
                                ListofBooks.DisplayBookList();
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
                        Console.WriteLine("Choose the Operation:\n1.Push a Character\n2.Pop a Character\n3.Display the Stack\n4.Exit");
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
                                StackOfCharacters.DisplayStackElements();
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
                        Console.WriteLine("Choose the Operation:\n1.Enqueue\n2.Dequeue\n3.Display\n4.Exit");
                        choiceOfQueueOperation = InputValidators.GetIntegerInput();
                        switch (choiceOfQueueOperation)
                        {
                            case (int)QueueOperations.AddQueue:
                                Queue.EnqueueNames();
                                break;
                            case (int)QueueOperations.DisplayQueue:
                                Queue.DisplayQueue();
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
                        Console.WriteLine("Choose the Operation:\n1.Add Dictionary element\n2.Display Dictionary element\n3.Delete Dictionary element\n4.Exit\n");
                        choiceOfDictionaryOperation = InputValidators.GetIntegerInput();
                        switch (choiceOfDictionaryOperation)
                        {
                            case (int)DictionaryOperations.AddGrades:
                                DictionaryofStudentDetails.AddDetails();
                                break;
                            case (int)DictionaryOperations.DisplayGrades:
                                DictionaryofStudentDetails.DisplayStudentDetails();
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
        }
    }
}