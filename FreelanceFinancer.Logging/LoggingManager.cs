using Microsoft.Extensions.Logging;

namespace FreelanceFinancer.Logging;

public class LoggingManager {
    private const int DefaultRetentionPeriod = 7;
    private readonly LoggingFileManager _fileManager;

    public LoggingManager (){
        _fileManager = new LoggingFileManager(DefaultRetentionPeriod);
    }

    public void LogDetails (LogLevel logLevel, string message, Exception? exception = null){
        if (exception != null){
            _fileManager.Log(logLevel, message, exception, (state, ex) => $"{state}: {ex?.Message}\nStackTrace: {ex?.StackTrace}");
        } else {
            _fileManager.Log(logLevel, message, null, (state, ex) => $"Message: {state}");
        }
    }
}