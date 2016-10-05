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
        private const string TextDotTxt = @"\DateTest.txt";
        private const string DateFormat = "yyyy/MM/dd";
        private const string Space = " ";
        #endregion

        #region Fields
        // readonly path to the destination folder
        private static readonly string path;
        //the file that is referred too
        
        #endregion

        #region Constructor
        /// <summary>
        /// a static constructor for initializing the readonly path
        /// </summary>
        static Logger()
        {
            //finds the file path and binds it to the "path"
            path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + TextDotTxt;
        }
        #endregion
        
        #region Properties

        #endregion

        #region Methods
        public static void Log(string message)
        {

            // checks if there is a file like the one in path, 
            // if yes then it overwrites it, if no then it creates a new one
            StreamWriter file = new StreamWriter(path, append: true);
            //writes a line equal to string message
            file.WriteLine(DateTime.Today.ToString(DateFormat) + Space + message);
            //closes the file for safety and stuff
            file.Close();

        }
        #endregion
    }
}
