namespace CCC.Entities
{
    #region Usings
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    #endregion

    class Message
    {
        #region Constants

        #endregion

        #region Fields
        /// <summary>
        /// Field for holding the text of the message
        /// </summary>
        private string messageText;
        /// <summary>
        /// Field for holding the reciever of the message
        /// </summary>
        private string messageReceiver;
        /// <summary>
        /// Field for holding the sender of the message
        /// </summary>
        private string messageSender;
        #endregion

        #region Constructor
        /// <summary>
        /// constructor for Message class
        /// </summary>
        /// <param name="sender">the sender of the message(string)</param>
        /// <param name="receiver">the reciever of the message(string)</param>
        /// <param name="message"></param>
        public Message(string sender, string receiver, string message)
        {
            MessageText = message;
            MessageReceiver = receiver;
            MessageSender = sender;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Property for the message text
        /// holds no validation to allow all kinds of text
        /// </summary>
        public string MessageText
        {
            get
            {
                return messageText;
            }

            set
            {
                messageText = value;
            }
        }

        /// <summary>
        /// Property for the message reciever
        /// </summary>
        public string MessageReceiver
        {
            get
            {
                return messageReceiver;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException;
                }
                if(value.Length > 10)
                {
                    throw new ArgumentException("The name is too long");
                }
                if(value.Length < 2)
                {
                    throw new ArgumentException("The name is too short");
                }
                else
                {
                    messageReceiver = value;
                }
                
            }
        }

        /// <summary>
        /// Property for message sender
        /// </summary>
        public string MessageSender
        {
            get
            {
                return messageSender;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException;
                }
                if (value.Length > 10)
                {
                    throw new ArgumentException("The name is too long");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException("The name is too short");
                }
                else
                {
                    messageSender = value;
                }
                
            }
        }
        #endregion

        #region Methods

        #endregion
    }
}
