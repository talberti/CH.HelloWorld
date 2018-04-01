using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Common.Data;
using API.Data;


namespace CH.HelloWorld.ConsoleClient
{
    class Program
    {
        // Initialize Nlog
        private static readonly NLog.ILogger logger = NLog.LogManager.GetCurrentClassLogger();

        // Initialize MessageProvider
        private static IMessageProvider messageProvider = new MessageProvider();

        static void Main(string[] args)
        {
            // Output Message
            logger.Info(messageProvider.Message);
        }
    }
}
