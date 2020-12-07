namespace Homework11
{
    using System;

    /// <summary>
    /// Start to Logger logic.
    /// </summary>
    internal sealed class Logger
    {
        /// <summary>
        /// 
        /// </summary>
        private static readonly Logger instance = new Logger();

        private Logger() { }

        /// <summary>
        /// Gets name of product.
        /// </summary>
        internal static Logger Instance
        {
            get
            {
                return instance;
            }
        }

        /// <summary>
        /// Make LogMessage - how the log will record.
        /// </summary>
        /// <param name="typeLog">Responsible for entering the log type.</param>
        /// <param name="message">Responsible for entering the message log.</param>
        internal void LogMessage(string typeLog, string message)
        {
            Console.WriteLine("[{0}]: {1}: {2}", DateTime.Now.ToLongTimeString(), typeLog, message);
        }
    }
}