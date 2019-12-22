using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    struct ClientMessage
    {
        public string name;
        public string message;
    }
    class ServerMessagesHandler
    {
        private List<ClientMessage> data = new List<ClientMessage>();
        public void Save(string msg)
        {
            int i = msg.IndexOf(":");
            string client = msg.Substring(0, i);
            string text = msg.Substring(i);
            ClientMessage clientMessage = new ClientMessage
            { 
                name = client,
                message = text
            };
            data.Add(clientMessage);
        }
        public List <ClientMessage> Show()
        {
            return data;
        }
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
