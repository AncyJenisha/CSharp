// <copyright file="PostFormater.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace StringManipualtion
{
    using System.Diagnostics.Tracing;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// PostFormator has methods for performing operations on the file content.
    /// </summary>
    public class PostFormater
    {
        /// <summary>
        /// Formats the content of a file.
        /// </summary>
        /// <param name="original">The string to be modified.</param>
        /// <returns>Modified string</returns>
        public string FormatPost(string original)
        {
            string formatted = Regex.Replace(original, @"[\r\n]{2}", "<p />");
            formatted = Regex.Replace(original, @"[\r\n]", "<p />");
            formatted.Trim();
            return formatted;
        }

        /// <summary>
        /// It extracts the words starting with '#'.
        /// </summary>
        /// <param name="original">The words in the file.</param>
        /// <returns>List of extracted words.</returns>
        public List<string> ExtractTags(string original)
        {
            List<string> listOfStrings = new List<string>();
            string[] arrayOfWords = original.Split(' ');
            foreach (string tag in arrayOfWords)
            {
                if (tag.StartsWith("#"))
                {
                    listOfStrings.Add(tag);
                }
            }

            return listOfStrings;
        }

        /// <summary>
        /// Search for the given string in the post.
        /// </summary>
        /// <param name="query">string to search</param
        /// <param name="content">Content of the file as string</param>
        /// <returns>If the string has the query or not</returns>
        public bool SearchPost(string query, string content)
        {
            PostFormater postFormater = new PostFormater();
            if (Regex.IsMatch(content, query, RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Analyzes the post for the number of occurance of each word.
        /// </summary>
        /// <param name="content">The contents of the file as string.</param>
        /// <returns>Dictionary of words and thier ocuurance</returns>
        public Dictionary<string, int> AnalyzeText(string content)
        {
            List<string> listOfPosts = new List<string>();
            Dictionary<string, int> wordOccurance = new Dictionary<string, int>();
            string[] arrayOfCommonWords = { "the", "is", "which", "at", "on", "in", "This"};

            PostFormater postFormater = new PostFormater();
            string[] arrayOfWordsFromPost = content.Split(' ');
            List<string> listOfWordsFromPostWithNoCommonWords = arrayOfWordsFromPost.Where(words => !arrayOfCommonWords.Contains(words)).ToList();
            foreach (string checkWord in listOfWordsFromPostWithNoCommonWords)
            {
                if (!wordOccurance.ContainsKey(checkWord))
                {
                    int count = 0;
                    foreach (string word in listOfWordsFromPostWithNoCommonWords)
                    {
                        if (!wordOccurance.ContainsKey(word) && checkWord == word)
                        {
                            count++;
                        }
                    }

                    wordOccurance.Add(checkWord, count);
                }
            }

            return wordOccurance;
        }

        /// <summary>
        /// Compares the firstpost content and secondpost content to calculate the similarityindex.
        /// </summary>
        /// <param name="firstPost">The string with the contents of first post</param>
        /// <param name="secondPost">The string with the contents of second post</param>
        /// <returns>similarity index of two posts</returns>
        public double ComparePosts(string firstPost, string secondPost)
        {
            string[] arrayOfWordsFromFirstPost = firstPost.Split(" ");
            string[] arrayOfWordsFromSecondPost = secondPost.Split(" ");
            Dictionary<string, int> occuranceOfWord = new Dictionary<string, int>();

            foreach (string word in arrayOfWordsFromFirstPost)
            {
                word.ToLower();
            }

            foreach (string word in arrayOfWordsFromSecondPost)
            {
                word.ToLower();
            }

            int identicalWordCount = 0;

            foreach (string word in arrayOfWordsFromFirstPost)
            {
                if (arrayOfWordsFromSecondPost.Contains(word))
                {
                    identicalWordCount++;
                }
            }

            double similarityIndex = (double)identicalWordCount * 2 / (arrayOfWordsFromFirstPost.Length + arrayOfWordsFromSecondPost.Length);
            return similarityIndex;
        }

        /// <summary>
        /// Returns list of Urls in the post
        /// </summary>
        /// <param name="originalContent">The content of posts as string.</param>
        /// <returns>list of urls</returns>
        public List<string> ParseURLs(string originalContent)
        {
            List<string> listOfEmails = new List<string>();
            string[] arrayOfWords = originalContent.Split(" ");
            foreach (string word in arrayOfWords)
            {
                if (Regex.IsMatch(word, "[(http(s) ?):\\/\\/ (www\\.) ? a - zA - Z0 - 9@:%._\\+~#=]{2,256}\\.[a-z]{2,6}\\b([-a-zA-Z0-9@:%_\\+.~#?&//=]*)"))
                {
                    listOfEmails.Add(word);
                }
            }

            return listOfEmails;
        }

        /// <summary>
        /// Concatenates the titles of all the posts into a single string using StringBuilder.
        /// </summary>
        /// <param name="content">Content of the file</param>
        /// <param name="title">The title of the file.</param>
        /// <returns>Stringbuilder object.</returns>
        public string ConcatenateTitles(string content, StringBuilder title)
        {
            title.Append(Regex.Match(content, "(<TITLE>).*?(</TITLE>)")).Replace("</TITLE>", "\n").Replace("<TITLE>", string.Empty);
            return title.ToString();
        }
    }
}