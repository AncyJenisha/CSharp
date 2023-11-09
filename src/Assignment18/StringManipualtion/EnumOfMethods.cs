// <copyright file="EnumOfMethods.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace StringManipualtion
{
    /// <summary>
    /// Has the methods to be called.
    /// </summary>
    public enum EnumOfMethodCalls
    {
        /// <summary>
        /// Calls the method which formats the strings.
        /// </summary>
        FormatPost = 1,

        /// <summary>
        /// Calls the method which extracts the tags.
        /// </summary>
        ExtractTags,

        /// <summary>
        /// Calls the method which searches the post for the specified string.
        /// </summary>
        SearchPost,

        /// <summary>
        /// Calls the method which analyzes the texts.
        /// </summary>
        AnalyzeText,

        /// <summary>
        /// Calls the method which compares the posts.
        /// </summary>
        ComparePost,

        /// <summary>
        /// Calls the method to get list of urls in the post.
        /// </summary>
        GetUrls,

        /// <summary>
        /// Calls the mathod which concatenates the file titles and returns as string.
        /// </summary>
        ConcatenateTitles,

        /// <summary>
        /// Exits the program.
        /// </summary>
        Exit,
    }
}