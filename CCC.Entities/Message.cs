using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCC.Entities
{
    class Message
    {
        #region Constants

        #endregion

        #region Fields
        private string messageText;
        private string messageReceiver;
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

        public string MessageReceiver
        {
            get
            {
                return messageReceiver;
            }

            set
            {
                messageReceiver = value;
            }
        }

        public string MessageSender
        {
            get
            {
                return messageSender;
            }

            set
            {
                messageSender = value;
            }
        }
        #endregion

        #region Methods

        #endregion
    }
}
