namespace TaskManager
{
    public class Logger
    {
        public void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}:{logMessage}");
        }

        public void DisplayLog()
        {
            StreamReader streamReadaer = new StreamReader("Log.txt");
            string? line = streamReadaer.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = streamReadaer.ReadLine();
            }
            streamReadaer.Close();
        }
    }
}