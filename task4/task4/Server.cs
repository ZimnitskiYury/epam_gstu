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
        const string ip = "127.0.0.1";
        const int port = 8080;
        IPEndPoint tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
        Socket tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {
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
                Console.WriteLine(data);
                listener.Send(Encoding.UTF8.GetBytes("Transliteration"));
            }
            //в метод который делает транслитерацию
        }
        /// <summary>
        /// 
        /// </summary>
    }
}
