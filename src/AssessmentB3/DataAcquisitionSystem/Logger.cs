using System.IO;
using System.Reflection;

namespace DataAcquisitionSystem
{
    /// <summary>
    /// Logger - Has methods to write the log to Log File
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// LogWrite - Writes the message to the log file.
        /// </summary>
        /// <param name="logMessage">The message to be logged.</param>
        public void LogWrite(string logMessage)
        {
            try
            {
                using (StreamWriter streamWriter = File.AppendText("log.txt"))
                {
                    Log(logMessage, streamWriter);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
        }

        /// <summary>
        /// Log - Formats the log message to be written to file.
        /// </summary>
        /// <param name="message">The message to be written</param>
        /// <param name="textWriter">The textWriter object.</param>
        public void Log(string message, TextWriter textWriter) 
        {
            try
            {
                textWriter.Write("\r\nLog Entry : ");
                textWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                textWriter.WriteLine(message);
                textWriter.WriteLine("-------------------------------");
            }
            catch (Exception exception)
            {
                textWriter.WriteLine(exception.ToString());
            }
        }
    }
}