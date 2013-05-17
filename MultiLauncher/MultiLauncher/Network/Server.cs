using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Net;

namespace MultiLauncher.Network
{
    public class Server
    {
        public readonly int PORT = 3045;

        //public TcpClient client;
        public Socket socket;

        public Server()
        {
            Thread th = new Thread(new ParameterizedThreadStart(run));
            th.Start();
        }

        public void run(Object o)
        {
            //client = new TcpClient();
            //client.Connect("localhost", PORT);
            //socket = client.Client;
            IPEndPoint ipe = new IPEndPoint(System.Net.IPAddress.Loopback, PORT);
            socket = new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("localhost", PORT);
            readLine();
            writeLine("Connect ML");
        }

        public string readLine()
        {
            byte[] buffer = new byte[256];
            socket.Receive(buffer);
            MessageBox.Show( Encoding.ASCII.GetString(buffer));
            return " ";
        }

        public void writeLine(string line)
        {
            socket.Send(Encoding.ASCII.GetBytes(line));
        }
    }
}
