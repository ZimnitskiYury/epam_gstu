using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    /// <summary>
    /// Struct for data about Sender of message and message
    /// </summary>
    struct ClientMessage
    {
        public string name;
        public string message;
    }
    /// <summary>
    /// Class saves all messages and senders
    /// </summary>
    class ServerMessagesHandler
    {
        private List<ClientMessage> data = new List<ClientMessage>();
        /// <summary>
        /// Save Client and message in List
        /// </summary>
        /// <param name="msg">Message from client</param>
        public void Save(string msg)
        {
            int i = msg.IndexOf(":");
            string client = msg.Substring(0, i);
            string text = msg.Substring(i+1);
            ClientMessage clientMessage = new ClientMessage
            { 
                name = client,
                message = text
            };
            data.Add(clientMessage);
        }
        /// <summary>
        /// Show all saved messages
        /// </summary>
        /// <returns>List with Name of client and message</returns>
        public List<ClientMessage> Show()
        {
            return data;
        }
        /// <summary>
        /// Show messages from only one client
        /// </summary>
        /// <param name="n">Input name of client</param>
        /// <returns>List messages from only one client</returns>
        public List<ClientMessage> Show(string n)
        {
            List<ClientMessage> clientdata = new List<ClientMessage>();
            foreach(var c in data)
            {
                if (c.name == n)
                {
                    clientdata.Add(c);
                }
            }
            return clientdata;
        }
    }
}
