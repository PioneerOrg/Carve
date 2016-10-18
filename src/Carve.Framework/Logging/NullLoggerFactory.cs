using System;

namespace Carve.Logging {
    class NullLoggerFactory : ILoggerFactory {
        public ILogger CreateLogger(Type type) {
            return NullLogger.Instance;
        }
    }
}