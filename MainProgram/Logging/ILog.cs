namespace MainProgram;

public interface ILog
{
     //put the stubbed out methods here...
     public void LogException(string message, Exception ex);
     public void LogStart(string message);
     
     public void LogError(string message);
     
     
}