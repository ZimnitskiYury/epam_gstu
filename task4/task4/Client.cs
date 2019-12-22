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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public delegate string MessageAnswerEventHandler(string message);
        /// <summary>
        /// 
        /// </summary>
        public event MessageAnswerEventHandler OnAnswer;

        string ip;
        int port;
        ClientMessagesHandler clientHandler = new ClientMessagesHandler();
        /// <summary>
        /// 
        /// </summary>
        public Client()
        {
            ip = "127.0.0.1";
            port = 8080;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="i">Ip for connect to server</param>
        /// <param name="p">Port for connect to server</param>
        public Client(string i, int p)
        {
            ip = i;
            port = p;
        }
        /// <summary>
        /// 
        /// </summary>
        public void Send(string name, string msg)
        {
            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var data = Encoding.UTF8.GetBytes(""+name+":"+msg);
            tcpSocket.Connect(tcpEndPoint);
            tcpSocket.Send(data);
            tcpSocket.Shutdown(SocketShutdown.Both);
            tcpSocket.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        public string Receive()
        {
            OnAnswer += clientHandler.Transliteration;
            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var taken = new byte[256];
            var size = 0;
            var answer = new StringBuilder();
            do
            {
                size = tcpSocket.Receive(taken);
                answer.Append(Encoding.UTF8.GetString(taken, 0, size));
            }
            while (tcpSocket.Available > 0);
            OnAnswer?.Invoke(answer.ToString());
            tcpSocket.Shutdown(SocketShutdown.Both);
            tcpSocket.Close();
            return answer.ToString();
        }
    }
}
