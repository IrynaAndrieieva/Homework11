namespace Homework11
{
    using System;
    using System.IO;
    using System.Reflection;

    /// <summary>
    /// FileService for writing the logger to a file.
    /// </summary>
    public class FileService
    {
        /// <summary>
        /// A method that describes the saving of text in txt.
        /// </summary>
        /// <param name="typeLog"> Responsible for entering the log type.</param>
        /// <param name="message"> Responsible for entering the message log.</param>
        public static void WriteLine(string typeLog, string message)
        {
            // создание тхт файла
            using (StreamWriter sw = new StreamWriter(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "Log.txt", true))
            {
                sw.WriteLine(string.Format("{0}: {1}: {2}", DateTime.Now.ToLongTimeString(), typeLog, message));
            }
        }
    }
}
