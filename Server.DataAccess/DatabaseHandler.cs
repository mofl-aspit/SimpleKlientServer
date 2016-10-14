namespace Server.DataAccess
{
    #region Usings
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    #endregion
    class DatabaseHandler
    {
        #region Constants

        #endregion

        #region Fields
        private string connectionString;
        private SqlConnection Sqlcon;
        private SqlCommand command;
        #endregion

        #region Constructor

        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// A method for closing a database connection
        /// </summary>
        public void CloseDBCon()
        {
            try
            {
                //checks if there is a connection, and then closes it
                if (this.Sqlcon != null)
                {
                    this.Sqlcon.Close();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            
        }

        /// <summary>
        /// A method for opening the connection to the database
        /// </summary>
        protected void OpenDBCon()
        {
            try
            {
                //checks if there is a connection and if its closed
                //and then opens it
                if (Sqlcon.State == ConnectionState.Closed)
                {
                    Sqlcon.Open();
                }
                //incase something of the above doesn't seem to work
                //make sure the connection is closed and then open it
                else
                {
                    CloseDBCon();
                    OpenDBCon();
                }
            }
            //catches with an sql exception
            catch (SqlException ex)
            {
                throw ex;
            } 
        }
        #endregion
    }
}
