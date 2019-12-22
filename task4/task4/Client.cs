using System.Net;
using System.Net.Sockets;
using System.Text;

namespace task4
{
    /// <summary>
    /// Client for TCP/IP connection to server
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Delegate for event
        /// </summary>
        /// <param name="message">Input message from server</param>
        public delegate string MessageAnswerEventHandler(string message);
        /// <summary>
        /// Event on answer from server
        /// </summary>
        public event MessageAnswerEventHandler OnAnswer;
        /// <summary>
        /// Ip address for connection to server
        /// </summary>
        string ip;
        /// <summary>
        /// Port for connection to server
        /// </summary>
        int port;
        ClientMessagesHandler clientHandler = new ClientMessagesHandler();
        /// <summary>
        /// Default constructor 
        /// </summary>
        public Client()
        {
            ip = "127.0.0.1";
            port = 8080;
        }
        /// <summary>
        /// Constructor for custom Ip and Port
        /// </summary>
        /// <param name="i">Ip for connect to server</param>
        /// <param name="p">Port for connect to server</param>
        public Client(string i, int p)
        {
            ip = i;
            port = p;
        }
        /// <summary>
        /// Send message to server from Name-user
        /// </summary>
        /// <param name="name">Name of user</param>
        /// <param name="msg">Message from User</param>
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
        /// REceive message from server
        /// </summary>
        /// <returns>Return message - string</returns>
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
