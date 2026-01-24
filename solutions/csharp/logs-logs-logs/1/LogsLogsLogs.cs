public enum LogLevel
{
    Unknown=0,
    Trace=1,
    Debug=2,
    Info=4,
    Warning=5,
    Error=6,
    Fatal=42
}
static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        string level = logLine.Substring(1,3);
        if(level == "TRC") return LogLevel.Trace;
        if(level == "DBG") return LogLevel.Debug;
        if(level == "INF") return LogLevel.Info;
        if(level == "WRN") return LogLevel.Warning;
        if(level == "ERR") return LogLevel.Error;
        if(level == "FTL") return LogLevel.Fatal;
        return LogLevel.Unknown;
        
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return $"{(int)logLevel}:{message}";
    }
}
