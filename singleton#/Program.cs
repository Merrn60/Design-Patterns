using System;

namespace SingletonExample
{
    public class DatabaseConnectionManager
    {
        // Private static field to hold the single instance of the class
        private static DatabaseConnectionManager _instance;

        // Lock object for thread-safety
        private static readonly object _lock = new object();

        // Private constructor to prevent instantiation
        private DatabaseConnectionManager()
        {
            Console.WriteLine("Database connection manager initialized.");
        }

        // Public static method to get the single instance
        public static DatabaseConnectionManager Instance
        {
            get
            {
                // Double-checked locking to ensure thread safety and performance
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DatabaseConnectionManager();
                        }
                    }
                }
                return _instance;
            }
        }

        // Example method to simulate database operations
        public void Connect()
        {
            Console.WriteLine("Connecting to the database...");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnecting from the database...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Access the singleton instance
            var dbManager1 = DatabaseConnectionManager.Instance;
            dbManager1.Connect();

            var dbManager2 = DatabaseConnectionManager.Instance;
            dbManager2.Disconnect();

            // Verify both instances are the same
            Console.WriteLine($"Are instances the same? {dbManager1 == dbManager2}");
        }
    }
}
