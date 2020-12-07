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

        /// <summary>
        /// Make message from Info.
        /// </summary>
        public void LoggerInfo()
        {
            this.logger.LogMessage("Info", "Start method");
        }

        /// <summary>
        /// Maked message from Warning and attempt make BusinessException.
        /// </summary>
        public void LoggeWarning()
        {
            this.logger.LogMessage("Warning", "Action got this custom Exception"); 

            //throw new BusinessException("Skipped logic in method: BusinessException");
        }

        /// <summary>
        /// Maked message from Error and maked Exception.
        /// </summary>
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
