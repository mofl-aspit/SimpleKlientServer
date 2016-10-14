namespace Server.DataAccess
{
    #region Usings
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using System.Reflection;
    using CCC.Entities;
    #endregion

    public static class Logger
    {
        #region Constants
        /// <summary>
        /// specifies which txt file is needed
        /// </summary>
        private const string TextDotTxt = @"\DateTest.txt";
        /// <summary>
        /// specifies the format for the date time, remember to reinsert .HH:mm.ss on the ending
        /// </summary>
        private const string DateFormat = "yyyy.MM.dd";
        /// <summary>
        /// avoids hardcoding for spaces in text file
        /// </summary>
        private const string Space = " ";
        #endregion

        #region Fields
        /// <summary>
        ///  readonly path to the destination folder
        /// </summary>
        private static readonly string path;
        #endregion
        
        #region Constructor
        /// <summary>
        /// a static constructor for initializing the readonly path
        /// </summary>
        static Logger()
        {
            try
            {
                //finds the file path and binds it to the "path"
                path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + TextDotTxt;
            }
            //AE = Argument Exeption
            catch(ArgumentException)  { throw; }
            //PE = Path Exeption
            catch(PathTooLongException) { throw; }
            //NE = Not Exeption
            catch(NotSupportedException) { throw; }
            
        }
        #endregion
        
        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// method for creating a log or writing to an existing log
        /// </summary>
        /// <param name="message">the log message(string)</param>
        public static void Log(string message)
        {
            try
            {
                // checks if there is a file like the one in path, 
                // if yes then it overwrites it, if no then it creates a new one
                StreamWriter file = new StreamWriter(path, append: true);
                //writes a line equal to string message
                file.WriteLine($"{DateTime.Now.ToString(DateFormat)}" + Space + message);
                //closes the file for safety and stuff
                file.Close();
            }
            //UE = Unathorized Exeption
            catch(UnauthorizedAccessException) { throw; }
            //AE = ArgumentExeption
            catch(ArgumentException) { throw; }
            //DE = Directory Exeption
            catch(DirectoryNotFoundException) { throw; }
            //IE = I Exeption
            catch(IOException) { throw; }
            //OE = Object Exeption
            catch(ObjectDisposedException) { throw; }
            //FE = Format Exeption
            catch(FormatException) { throw; }
        }
        #endregion
    }
}
