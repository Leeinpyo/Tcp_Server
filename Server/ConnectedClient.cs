using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tcp_Server
{
    public class ConnectedClient
    {
        private Server controlForm;
        private TcpClient client;
        private int myNumber;
        private NetworkStream stream;
        private Thread receiveThread;
        private bool connecting = true;

        private byte[] buff = new byte[1024];
        private int nbytes;
        private string message;

        private byte[] stringByte;

        private const string closeMsg = "/CloseServer";

        public ConnectedClient(Server server, TcpClient connClient, int clientNo)
        {
            controlForm = server;
            client = connClient;
            myNumber = clientNo;
            stream = client.GetStream();

            receiveThread = new Thread(Receiving)
            {
                IsBackground = true
            };
            receiveThread.Start();
        }

        private void Receiving()
        {
            while (connecting)
            {
                try
                {
                    nbytes = stream.Read(buff, 0, buff.Length);
                    message = Encoding.UTF8.GetString(buff, 0, nbytes);

                    switch (message)
                    {
                        case closeMsg:
                            CloseConnection();
                            break;
                        default:
                            controlForm.MessageReceived(myNumber, message);
                            break;
                    }
                }
                catch { }
            }
        }

        public void CloseConnection()
        {
            SendMsg(closeMsg);
            connecting = false;
            stream.Close();
            client.Close();
            controlForm.CloseConnection(myNumber);
        }

        public void SendMsg(string text)
        {
            try
            {
                stringByte = Encoding.UTF8.GetBytes(text);
                stream.Write(stringByte, 0, stringByte.Length);
                stream.Flush();
            }
            catch { }
        }
    }
}