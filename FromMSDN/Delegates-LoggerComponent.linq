<Query Kind="Program" />

void Main()
{
	//Logger.WriteMessage += LoggingMethods.LogToConsole;
	var fileLogger = new FileLogger(@"D:\log.txt");
	Logger.LogMessage(Severity.Warning,"me","testing");
	//Logger.WriteMessage -= LoggingMethods.LogToConsole;
	
}

// Define other methods and classes here
public static class Logger
{
    public static Action<string> WriteMessage;

	public static Severity LogLevel {get;set;} = Severity.Warning;
    public static void LogMessage(Severity s, string component, string msg)
    {
        if (s < LogLevel)
            return;
            
        var outputMsg = $"{DateTime.Now}\t{s}\t{component}\t{msg}";
        WriteMessage(outputMsg);
    }
}

public static class LoggingMethods
{
    public static void LogToConsole(string message)
    {
        Console.WriteLine(message);
    }
}

public class FileLogger
{
    private readonly string logPath;
    public FileLogger(string path)
    {
        logPath = path;
		Console.WriteLine("called");
        Logger.WriteMessage += LogMessage;
    }

    public void DetachLog() => Logger.WriteMessage -= LogMessage;
    // make sure this can't throw.
    private void LogMessage(string msg)
    {
        try
        {
            using (var log = File.AppendText(logPath))
            {
				Console.WriteLine(msg);
                log.WriteLine(msg);
                log.Flush();
            }
        }
        catch (Exception)
        {
            // Hmm. We caught an exception while 
            // logging. We can't really log the 
            // problem (since it's the log that's failing).
            // So, while normally, catching an exception
            // and doing nothing isn't wise, it's really the
            // only reasonable option here.
        }
    }
}
public enum Severity
{
    Verbose,
    Trace,
    Information,
    Warning,
    Error,
    Critical
}