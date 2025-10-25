using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.SOLID.example
{
    public interface ILogger
    {
        void LogError(string message);
    }

    public class FileLogger : ILogger
    {
        public void LogError(string message)
        {
            // Logic to log error message to a file
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void LogError(string message)
        {
            // Logic to log error message to a database
        }
    }
}
