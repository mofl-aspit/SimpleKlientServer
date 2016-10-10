namespace Server.DataAccess
{
    //Usings
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
        //specifies which txt file is needed
        private const string TextDotTxt = @"\DateTest.txt";
        //specifies the format for the date time, remember to reinsert .HH:mm.ss on the ending
        private const string DateFormat = "yyyy.MM.dd";
        //avoids hardcoding for spaces in text file
        private const string Space = " ";
        #endregion

        #region Fields
        // readonly path to the destination folder
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
            catch(ArgumentException AE)  { throw AE; }
            //PE = Path Exeption
            catch(PathTooLongException PE) { throw PE; }
            //NE = Not Exeption
            catch(NotSupportedException NE) { throw NE; }
            
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
            catch(UnauthorizedAccessException UE) { throw UE; }
            //AE = ArgumentExeption
            catch(ArgumentException AE) { throw AE; }
            //DE = Directory Exeption
            catch(DirectoryNotFoundException DE) { throw DE; }
            //IE = I Exeption
            catch(IOException IE) { throw IE; }
            //OE = Object Exeption
            catch(ObjectDisposedException OE) { throw OE; }
            //FE = Format Exeption
            catch(FormatException FE) { throw FE; }
        }
        #endregion
    }
}
