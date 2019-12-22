using System.Net;
using System.Net.Sockets;
using System.Text;

namespace task4
{
    /// <summary>
    /// Server for TCP/IP connection to server
    /// </summary>
    public class Server
    {
        /// <summary>
        /// Delegate for event
        /// </summary>
        /// <param name="message">Message from client</param>
        public delegate void MessageReceivedEventHandler(string message);
        /// <summary>
        /// Event on receive message from client
        /// </summary>
        public event MessageReceivedEventHandler onReceived;
        /// <summary>
        /// Ip address for connection to server
        /// </summary>
        string ip;
        /// <summary>
        /// Port for connection to server
        /// </summary>
        int port;
        ServerMessagesHandler serverHandler = new ServerMessagesHandler();
        /// <summary>
        /// Default constructor
        /// </summary>
        public Server()
        {
            ip = "127.0.0.1";
            port = 8080;
        }
        /// <summary>
        /// Constructor for custom Ip and Port
        /// </summary>
        /// <param name="i">Ip address for connection</param>
        /// <param name="p">Port for connection</param>
        public Server(string i, int p)
        {
            ip = i;
            port = p;
        }
        /// <summary>
        /// Start to listen socket
        /// </summary>
        public void Start()
        {
            IPEndPoint tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            Socket tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            onReceived += serverHandler.Save;
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
                listener.Shutdown(SocketShutdown.Both);
                listener.Close();
            }
        }
        /// <summary>
        /// Send message to Client
        /// </summary>
        /// <param name="t">String with nessage to client</param>
        public void Answer(string t)
        {
            IPEndPoint tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            Socket tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var data = Encoding.UTF8.GetBytes(t);
            tcpSocket.Connect(tcpEndPoint);
            tcpSocket.Send(data);
            tcpSocket.Shutdown(SocketShutdown.Both);
            tcpSocket.Close();
        }
    }
}
