using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OyunServer
{
    class Client
    {

        public TcpClient socket;
        public NetworkStream stream;
        private byte[] recBuffer;
        public Kaan_ByteBuffer buffer;
        public int connectionID;

        public void Start()
        {
            socket.SendBufferSize = 4096;
            socket.ReceiveBufferSize = 4096;
            stream = socket.GetStream();
            recBuffer = new byte[4096];
            stream.BeginRead(recBuffer, 0, socket.ReceiveBufferSize, OnReceivaData, null);
        }
        private void OnReceivaData(IAsyncResult result)
        {
            try
            {
                int length = stream.EndRead(result);
                if(length<=0)
                {
                    CloseConnection();
                    return;
                }
                byte[] newBytes = new byte[length];
                Array.Copy(recBuffer, newBytes, length);
                ServerHandleData.HandleData(connectionID,newBytes);
                stream.BeginRead(recBuffer,0,socket.ReceiveBufferSize,OnReceivaData,null);
            }
            catch(Exception)
            {
                CloseConnection();
                throw;
                //Hata Oluşursa
            }
        }
        private void CloseConnection()
        {
            Sabitler.bagli_client.Remove(connectionID);
            Sabitler.oyuncu_cikdi(connectionID.ToString());
            socket.Close();
        }
    }
}
