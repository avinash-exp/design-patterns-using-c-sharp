// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using Singleton;
var logger1 = Logger.Instance;
logger1.Log("Hello, World!");
var logger2 = Logger.Instance;
logger2.Log("Hello, World!");
if  (logger1 == logger2) {
    Console.WriteLine("logger1 and logger2 are the same instance");
}
else {
    Console.WriteLine("logger1 and logger2 are different instances");
}




var logger3 = ThreadSafeSingletonWithLock.Logger.Instance;
logger3.Log("Hello, World!");
var tasks_2 = new List<Task>();
for (int i = 0; i < 100; i++)
{
    tasks_2.Add(Task.Run(() =>
    {
        var logger = ThreadSafeSingletonWithLock.Logger.Instance;
        // logger.Log("Logging from thread " + Task.CurrentId);
    }));
}
Task.WaitAll(tasks_2.ToArray());

var allLoggersSame_2 = tasks_2.All(task =>
{
    var logger = ThreadSafeSingletonWithLock.Logger.Instance;
    return logger == logger3;
});

if (allLoggersSame_2)
{
    Console.WriteLine("All logger instances are the same");
}
else
{
    Console.WriteLine("Not all logger instances are the same");
}

var logger4 = ThreadSafeSingletonWithLock.Logger.Instance;
logger4.Log("Hello, World!");
if  (logger3 == logger4) {
    Console.WriteLine("logger3 and logger4 are the same instance");
}
else {
    Console.WriteLine("logger3 and logger4 are different instances");
}

var logger5 = ThreadSafeSingletonWithBuiltinLazy.Logger.Instance;
logger5.Log("Hello, World!");
var logger6 = ThreadSafeSingletonWithBuiltinLazy.Logger.Instance;
logger6.Log("Hello, World!");
if  (logger5 == logger6) {
    Console.WriteLine("logger5 and logger6 are the same instance");
}
else {
    Console.WriteLine("logger5 and logger6 are different instances");
}