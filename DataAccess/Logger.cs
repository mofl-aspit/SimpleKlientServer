using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    public static class Logger
    {
        #region Constants

        #endregion

        #region Fields
        private static readonly string path = @"C:\S kode mappe\SimpleClientServer\test.txt";
        #endregion

        #region Constructor
        static Logger() { }
        

        #endregion

        #region Properties

        #endregion

        #region Methods
        public static void log(string message)
        {
            // checks if there is a file like the one in path, if yes then it overwrites it, if no then it creates a new one
            System.IO.StreamWriter file = new System.IO.StreamWriter(path, true);
            //writes a line equal to string message
            file.WriteLine(message);
            //closes the file for safety and stuff
            file.Close();

        }
        #endregion
    }
}
