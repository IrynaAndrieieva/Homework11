namespace Homework11
{
    using System;

    /// <summary>
    /// Added class from BusinessException.
    /// </summary>
    public class BusinessException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessException"/> class.
        /// Make metod BusinessException from our Exception.
        /// </summary>
        /// <param name="message"> From message about Error.</param>
        public BusinessException(string message)
           : base(message)
        {
        }
    }
}
