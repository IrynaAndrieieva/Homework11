namespace Homework11
{
    using System;

    /// <summary>
    /// Added class from BusinessException.
    /// </summary>
    public class BusinessException : Exception
    {
        /// <summary>
        /// Make metod BusinessException from our Exception.
        /// </summary>
        /// <param name="message"></param>
        public BusinessException(string message)
           : base(message)
        {
        }
    }
}
