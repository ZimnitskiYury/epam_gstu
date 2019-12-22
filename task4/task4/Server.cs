using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    /// <summary>
    /// 
    /// </summary>
    public class Server
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public delegate void MessageReceivedEventHandler(string message);
        /// <summary>
        /// 
        /// </summary>
        public event MessageReceivedEventHandler onReceived;

        string ip;
        int port;
        ServerHandler serverHandler = new ServerHandler();
        /// <summary>
        /// 
        /// </summary>
        public Server()
        {
            ip = "127.0.0.1";
            port = 8080;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <param name="p"></param>
        public Server(string i, int p)
        {
            ip = i;
            port = p;
        }
        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {
            IPEndPoint tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            Socket tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            onReceived += serverHandler.SaveMessages;
            tcpSocket.Bind(tcpEndPoint);
            tcpSocket.Listen(1);
            while (true)
            {
                Socket listener = tcpSocket.Accept();
                var taken = new byte[256];
                var size = 0;
                var data = new StringBuilder();
                do
                {
                    size = listener.Receive(taken);
                    data.Append(Encoding.UTF8.GetString(taken, 0, size));
                }
                while (listener.Available > 0);
                onReceived(data.ToString());
                Console.WriteLine(data);
                listener.Shutdown(SocketShutdown.Both);
                listener.Close();
            }

        }
    }
}
