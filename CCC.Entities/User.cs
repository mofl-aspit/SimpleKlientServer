namespace CCC.Entities
{
    #region Usings
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    #endregion

    public class User
    {
        #region Constants

        #endregion

        #region Fields
        /// <summary>
        /// Field for holding the Username(string)
        /// </summary>
        private string username;
        /// <summary>
        /// Field for holding the Password(string)
        /// </summary>
        private string password;
        #endregion

        #region Constructor
        /// <summary>
        /// the Constructor for User
        /// </summary>
        /// <param name="username">string</param>
        /// <param name="password">string</param>
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Usernames Property with some validation and exception handling
        /// </summary>
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (value.Length > 20)
                {
                    throw new ArgumentException("the name is too long");
                }
                else if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("the name can't be empty");
                }
                else
                {
                    username = value;
                }
            }
        }

        /// <summary>
        /// Password Property with some validation and exception handling
        /// </summary>
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                if (value.Length > 30)
                {
                    throw new ArgumentException("the Password is too long");
                }
                else if (value.Length < 8)
                {
                    throw new ArgumentException("your Password is too short");
                }
                else if(Regex.IsMatch(value, @"^-?\d+$"))
                {
                    throw new ArgumentException("Password contains unauthorized characters");
                }
                else if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("the Password can't be empty");

                }
                else
                {
                    password = value;
                }

            }
        }


        #endregion

        #region Methods

        #endregion
    }
}
