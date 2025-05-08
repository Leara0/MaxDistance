namespace MainProgram;

public interface ILog
{
     //put the stubbed out methods here...
     public void LogInfo(string message);
     public void LogWarning(string message);
     public void LogDebug(string message);
     public void LogError(string log, Exception? exception = null);
     public void LogFatal(string message, Exception? ex =null);
}