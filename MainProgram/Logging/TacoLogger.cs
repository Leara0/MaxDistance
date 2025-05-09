namespace MainProgram;

public class TacoLogger : ILog
{
    public void LogInfo(string message)
    {
        Console.WriteLine($"Info: {message}");
    }

    public void LogWarning(string message)
    {
        Console.WriteLine($"Warning: {message}");
    }

    public void LogDebug(string message)
    {
        Console.WriteLine($"Debug: {message}");
    }

    public void LogError(string message, Exception? ex = null)
    {
        Console.WriteLine($"Error: {message}, Exception: {ex}");
    }

    public void LogFatal(string message, Exception? ex = null)
    {
        Console.WriteLine($"Fatal: {message}, Exception: {ex }");
    }
}