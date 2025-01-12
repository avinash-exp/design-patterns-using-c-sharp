namespace ThreadSafeSingletonWithLock {
    public class Logger {
        private static Logger? _instance;
        private static readonly object _lock = new object();
        private Logger() { }

        public static Logger Instance {
            get {
                lock (_lock) {
                    if (_instance == null) {
                        _instance = new Logger();
                    }
                    return _instance;
                }
            }
        }

        public void Log(string message) {
            System.Console.WriteLine(message);
        }
    }
}

namespace ThreadSafeSingletonWithBuiltinLazy {
    public class Logger {
        private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());
        private Logger() { }

        public static Logger Instance => _instance.Value;

        public void Log(string message) {
            System.Console.WriteLine(message);
        }
    }
}