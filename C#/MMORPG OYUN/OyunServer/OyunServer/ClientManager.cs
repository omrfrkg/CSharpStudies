using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OyunServer
{
    static class ClientManager
    {
        public static void  CreateNewConnection(TcpClient tempClient)
        {
            Client newClient = new Client();
            newClient.socket = tempClient;
            newClient.connectionID = ((IPEndPoint)tempClient.Client.RemoteEndPoint).Port;
            newClient.Start();
            Sabitler.bagli_client.Add(newClient.connectionID, newClient);
        }
    }
}
