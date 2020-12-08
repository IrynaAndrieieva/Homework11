namespace Homework11
{
    using System;

    /// <summary>
    /// Start buisness logic.
    /// </summary>
    public class Starter
    {
        /// <summary>
        /// Maked finaly logic.
        /// </summary>
        public void Run()
        {
            Actions actions = new Actions();

            Random rnd = new Random();
            int value = rnd.Next(0, 100);

            for (int numbers = 0; numbers < 100; numbers++)
            {
                if ((numbers + value) % 2 == 0)
                {
                    actions.LoggerInfo();
                }
                else if ((numbers + value) % 3 == 0)
                {
                    actions.LoggeWarning();
                }
                else
                {
                    actions.LoggerError();
                }
            }

            Console.ReadKey();
        }
    }
}
