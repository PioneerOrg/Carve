using System;

namespace Carve.Logging {
    public interface ILoggerFactory {
        ILogger CreateLogger(Type type);
    }
}