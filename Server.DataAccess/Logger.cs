namespace Server.DataAccess
{
    #region Usings
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using CCC.Entities;
    #endregion

    public static class Logger
    {
        #region Constants

        #endregion

        #region Fields
        private static readonly string path;
        #endregion

        #region Constructor
        static Logger()
        {
            //finds the file path and binds it to the "path"
            path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }
        #endregion
        
        #region Properties

        #endregion

        #region Methods
        public static void Log(string message)
        {
            // checks if there is a file like the one in path, 
            // if yes then it overwrites it, if no then it creates a new one
            StreamWriter file = new StreamWriter(path, true);
            //writes a line equal to string message
            file.WriteLine(message);
            //closes the file for safety and stuff
            file.Close();

        }
        #endregion
    }
}
