using System.IO;
using System.Reflection;

namespace DataAcquisitionSystem
{
    public class Logger
    {

        public Logger(string logMessage)
        {
            LogWrite(logMessage);
        }

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

        public void Log(string message, TextWriter textWriter) 
        {
            try
            {
                textWriter.Write("\r\nLog Entry : ");
                textWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                textWriter.WriteLine("  :");
                textWriter.WriteLine("  :{0}", message);
                textWriter.WriteLine("-------------------------------");
            }
            catch (Exception exception)
            {
                textWriter.WriteLine(exception.ToString());
            }
        }
    }
}