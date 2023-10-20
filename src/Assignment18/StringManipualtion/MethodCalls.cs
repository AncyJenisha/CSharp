// <copyright file="MethodCalls.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace StringManipualtion
{
    using System.Net.Mail;
    using System.Text;

    /// <summary>
    /// Has methods to call other methods.
    /// </summary>
    public static class MethodCalls
    {
        /// <summary>
        /// Calls FormatPost method.
        /// </summary>
        public static void CallFormatPost()
        {
            string directoryPath = "SW\\Bands\\";
            string[] files = Directory.GetFiles(directoryPath);
            foreach (string file in files)
            {
                using (FileStream fileReader = new FileStream(file, FileMode.Open))
                using (StreamReader streamReader = new StreamReader(fileReader))
                {
                    string content = streamReader.ReadToEnd();
                    PostFormater postFormater = new PostFormater();
                    postFormater.FormatPost(content);
                }
            }

            Console.WriteLine("All posts in the files are formated\n\n\n\n");
        }

        /// <summary>
        /// Calls the ExtractTags method.
        /// </summary>
        public static void CallExtractTags()
        {
            string directoryPath = "SW\\Bands\\";
            string[] files = Directory.GetFiles(directoryPath);
            foreach (string file in files)
            {
                using (FileStream fileReader = new FileStream(file, FileMode.Open))
                using (StreamReader streamReader = new StreamReader(fileReader))
                {
                    string content = streamReader.ReadToEnd();
                    PostFormater postFormater = new PostFormater();
                    List<string> listoftags = postFormater.ExtractTags(content);
                    foreach (string tag in listoftags)
                    {
                        Console.WriteLine(tag);
                    }
                }
            }

            Console.WriteLine("\n\n\n\n");
        }

        /// <summary>
        /// Calls the SearchQuery method.
        /// </summary>
        public static void CallSearchQuery()
        {
            string directoryPath = "SW\\Bands\\";
            string[] files = Directory.GetFiles(directoryPath);
            List<string> listOfPosts = new List<string>();
            Console.WriteLine("Enter the word to search");
            string query = InputValidators.GetStringInput();

            foreach (string file in files)
            {
                using (FileStream fileReader = new FileStream(file, FileMode.Open))
                using (StreamReader streamReader = new StreamReader(fileReader))
                {
                    string content = streamReader.ReadToEnd();
                    PostFormater postFormater = new ();
                    if (postFormater.SearchPost(query, content))
                    {
                        listOfPosts.Add(file);
                    }
                }
            }

            Console.WriteLine($"The following post has the word {query}:");
            foreach (string file in listOfPosts)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine("\n\n\n\n");
        }

        /// <summary>
        /// Calls the AnalyzeText method.
        /// </summary>
        public static void CallAnalyzeText()
        {
            string directoryPath = "SW\\Bands\\";
            string[] files = Directory.GetFiles(directoryPath);
            foreach (string file in files)
            {
                using (FileStream fileReader = new FileStream(file, FileMode.Open))
                using (StreamReader streamReader = new StreamReader(fileReader))
                {
                    string content = streamReader.ReadToEnd();
                    PostFormater postFormater = new PostFormater();
                    Dictionary<string, int> wordOccurance = postFormater.AnalyzeText(content);
                    foreach (KeyValuePair<string, int> kvp in wordOccurance)
                    {
                        Console.WriteLine($"{kvp.Key} : {kvp.Value}");
                    }
                }
            }

            Console.WriteLine("\n\n\n\n");
        }

        /// <summary>
        /// Calls the ComparePosts method.
        /// </summary>
        public static void CallComparePosts()
        {
            string directoryPath = "SW\\Bands\\";
            string[] files = Directory.GetFiles(directoryPath);
            PostFormater postFormatter = new PostFormater();
            string contentOfFirstPost;
            string contentOfSecondPost;
            List<string> listOfPosts = new List<string>();
            for (int i = 0; i < files.Length; i++)
            {
                using (FileStream firstFileReader = new FileStream(files[i], FileMode.Open))
                using (StreamReader firstStreamReader = new StreamReader(firstFileReader))
                {
                    contentOfFirstPost = firstStreamReader.ReadToEnd();
                    for (int j = i + 1; j < files.Length; j++)
                    {
                        using (FileStream secondFileReader = new FileStream(files[j], FileMode.Open))
                        using (StreamReader secondStreamReader = new StreamReader(secondFileReader))
                        {
                            contentOfSecondPost = secondStreamReader.ReadToEnd();
                        }

                        double similarityIndex = postFormatter.ComparePosts(contentOfFirstPost, contentOfSecondPost);
                        Console.WriteLine($"SimilarityIndex of {files[i]} and {files[j]}: {similarityIndex}");
                    }
                }
            }

            Console.WriteLine("\n\n\n\n");
        }

        /// <summary>
        /// Calls the ParseURLs method.
        /// </summary>
        public static void CallParseUrls()
        {
            string directoryPath = "SW\\Bands\\";
            List<string> listOfUrls = new ();
            string[] files = Directory.GetFiles(directoryPath);
            foreach (string file in files)
            {
                using (FileStream fileReader = new FileStream(file, FileMode.Open))
                using (StreamReader streamReader = new StreamReader(fileReader))
                {
                    string content = streamReader.ReadToEnd();
                    PostFormater postFormater = new PostFormater();
                    listOfUrls = postFormater.ParseURLs(content);
                }

                if (listOfUrls.Count > 0)
                {
                    Console.WriteLine($"\n\nThe Urls in {file}\n\n");
                    foreach (string url in listOfUrls)
                    {
                        Console.WriteLine(url);
                    }
                }
            }

            Console.WriteLine("\n\n\n\n");
        }

        /// <summary>
        /// Calls the concatenateTitles method.
        /// </summary>
        public static void CallConcatenateTitles()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string directoryPath = "SW\\Bands\\";
            string[] files = Directory.GetFiles(directoryPath);
            foreach (string file in files)
            {
                using (FileStream fileReader = new (file, FileMode.Open))
                using (StreamReader streamReader = new (fileReader))
                {
                    string content = streamReader.ReadToEnd();
                    PostFormater postFormater = new PostFormater();
                    postFormater.ConcatenateTitles(content, stringBuilder);
                }
            }

            Console.WriteLine($"The Concatenated titles: \n {stringBuilder}\n\n\n");
        }
    }
}