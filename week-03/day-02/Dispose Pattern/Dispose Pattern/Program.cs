using System;
using System.IO;
using System.Net.Http;
using System.Text;

namespace Dispose_Pattern
{
    class Program
    {
        static void Main(string[] args)
        { 
            var logger = new NetworkAndFileLogger("log.txt");

            logger.Log("First log message");
            logger.Log("Second log message");
        }
    }

    public class FileLogger : IDisposable
    {
        protected readonly FileStream fileStream;

        public FileLogger(string filePath)
        {
            fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                fileStream?.Dispose();
            }
        }

        public virtual void Log(string message)
        {
            // Implement the file logging. Every line should follow the format:
            // <current date and time> - <message>
            // e.g.
            // 2018-11-09T14:46:55.345 - This is a sample message
            // Hint: use StreamWriter

            using (StreamWriter writer = new StreamWriter(fileStream, Encoding.ASCII, 1024, true))
            {
                writer.WriteLine("{0} - {1}", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff"), message);
            }
        }
    }

    public class NetworkAndFileLogger : FileLogger
    {
        private readonly HttpClient httpClient;

        public NetworkAndFileLogger(string filePath) : base(filePath)
        {
            httpClient = new HttpClient();
        }

        public override void Log(string message)
        {
            httpClient.PostAsync("http://requestbin.fullcontact.com/19k1eyj1", new StringContent(message)).Wait();
        }
    }

}
