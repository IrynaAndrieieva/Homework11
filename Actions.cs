namespace Homework11
{
    using System;

    /// <summary>
    /// Our actions.
    /// </summary>
    public class Actions
    {
        /// <summary>
        /// Connected Logger to this class.
        /// </summary>
        Logger logger = Logger.Instance;

        public void LoggerInfo()
        {
            this.logger.LogMessage("Info", "Start method");
        }

        public void LoggeWarning()
        {
            this.logger.LogMessage("Warning", "Action got this custom Exception"); 

            //throw new BusinessException("Skipped logic in method: BusinessException");
        }

        public void LoggerError()
        {
            this.logger.LogMessage("Error", "Action failed by reason");

            try
            {
            }
            catch (Exception)
            {
                Console.WriteLine($"I broke a toilet");
            }
        }
    }
}
