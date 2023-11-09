// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace StringManipualtion
{
    /// <summary>
    /// Program Class has the main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method gets the choice of operation and calls the method specified by user.
        /// </summary>
        private static void Main()
        {
            int choice;
            do
            {
                Console.WriteLine("1.Post Formatting\n2.Tag Extraction\n3.Search Text\n4.Analyze Text\n5.Comapre Posts\n6.ParseURLs\n7.Concatenate Titles\n8.Exit");
                Console.WriteLine("Enter the choice of operation:");
                choice = InputValidators.GetIntegerInput();
                switch (choice)
                {
                    case (int)EnumOfMethodCalls.FormatPost:
                        MethodCalls.CallFormatPost();
                        break;
                    case (int)EnumOfMethodCalls.ExtractTags:
                        MethodCalls.CallExtractTags();
                        break;
                    case (int)EnumOfMethodCalls.SearchPost:
                        MethodCalls.CallSearchQuery();
                        break;
                    case (int)EnumOfMethodCalls.AnalyzeText:
                        MethodCalls.CallAnalyzeText();
                        break;
                    case (int)EnumOfMethodCalls.ComparePost:
                        MethodCalls.CallComparePosts();
                        break;
                    case (int)EnumOfMethodCalls.GetUrls:
                        MethodCalls.CallParseUrls();
                        break;
                    case (int)EnumOfMethodCalls.ConcatenateTitles:
                        MethodCalls.CallConcatenateTitles();
                        break;
                    case (int)EnumOfMethodCalls.Exit:
                        break;
                    default:
                        Console.WriteLine("Choose a valid Option\n");
                        break;
                }
            }
            while (choice != 8);
        }
    }
}