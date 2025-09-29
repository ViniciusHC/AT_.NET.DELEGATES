namespace Delegate.Delegates
{
    public class LogDelegate
    {
        public static Action<string> Log = LogToConsole;

        public static readonly List<string> Memory = new();

        public static void LogToConsole(string msg)
            => Console.WriteLine($"[LOG] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {msg}");

        public static void LogToFile(string msg)
        {
            var dir = Path.Combine("wwwroot", "logs");
            Directory.CreateDirectory(dir);
            var file = Path.Combine(dir, "app.log");
            File.AppendAllText(file, $"[LOG] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {msg}{Environment.NewLine}");
        }

        public static void LogToMemory(string msg)
            => Memory.Add($"[LOG] {DateTime.Now:HH:mm:ss} - {msg}");
    }
}
