using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------
using System.Net;
using System.Net.Sockets;


namespace MulServer
{
    class MyClient
    {
        public static List<Socket> listClient = new List<Socket>();

        public void Add(Socket soc)
        {
            listClient.Add(soc);
        }

        public void Delete(Socket soc)
        {
            listClient.Remove(soc);
        }

        public Socket[] getListAll()
        {
            return listClient.ToArray();
        }

        public void sendMessage(IPEndPoint Ipe, string Msg)
        {
            foreach (Socket s in listClient)
            {
                IPEndPoint iPEndPoint = s.RemoteEndPoint as IPEndPoint;
                if (Ipe.Address.ToString() == iPEndPoint.Address.ToString() && iPEndPoint.Port == Ipe.Port)
                {
                    byte[] b = Encoding.Unicode.GetBytes(Msg);
                    s.Send(b);
                }
            }
        }
    }
}
