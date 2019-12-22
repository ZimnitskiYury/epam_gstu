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
    public class Client
    {
        const string ip = "127.0.0.1";
        const int port = 8080;
        public void Start()
        {
            
            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var message = "text";
            var data = Encoding.UTF8.GetBytes(message);
            tcpSocket.Connect(tcpEndPoint);
            tcpSocket.Send(data);

            var taken = new byte[256];
            var size = 0;
            var answer = new StringBuilder();
            do
            {
                size = tcpSocket.Receive(taken);
                answer.Append(Encoding.UTF8.GetString(taken, 0, size));
            }
            while (tcpSocket.Available > 0);
            tcpSocket.Shutdown(SocketShutdown.Both);
            tcpSocket.Close();
        }
    }
}
