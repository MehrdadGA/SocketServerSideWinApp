using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-----------------------------------------------------
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace MulServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void startServer()
        {
            try
            {
                Socket serverSoc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                this.Invoke((MethodInvoker)delegate
                {
                    serverSoc.Bind(new IPEndPoint(IPAddress.Parse(txt_IP.Text), int.Parse(txt_Port.Text)));
                    serverSoc.Listen(1);
                });

                while (true)
                {
                    Socket clientSok = serverSoc.Accept();
                    MyClient m = new MyClient();
                    m.Add(clientSok);
                    showListAllClient();
                    Thread tr = new Thread(getData);
                    tr.Start(clientSok);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("The Error has been occured :: Maybe You are connected now","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Thread tr = new Thread(new ThreadStart(startServer));
            tr.IsBackground = true; 
            tr.Start();
        }

        public void getData(object ObjSoc)
        {
            Socket Soc = (Socket)ObjSoc;
            while (true)
            {
                byte[] b = new byte[1024];
                int r = Soc.Receive(b);
                if (r > 0)
                {
                    this.Invoke((MethodInvoker)delegate
                   {
                       lst_Message.Items.Add(Encoding.Unicode.GetString(b, 0, r));
                   });
                }
            }
        }

        public void showListAllClient()
        {
            MyClient m = new MyClient();
            Socket[] msoc = m.getListAll();
            this.Invoke((MethodInvoker)delegate
            {
                lst_ClientList.Items.Clear();
                foreach (Socket s in msoc)
                {
                    IPEndPoint ip = s.RemoteEndPoint as IPEndPoint;
                    lst_ClientList.Items.Add(ip.Address + "  ");
                }
            });
        }

        private void btn_SendAll_Click(object sender, EventArgs e)
        {
            MyClient m = new MyClient();
            Socket[] asoc = m.getListAll();
            byte[] bmsg = new byte[1024];
            bmsg = Encoding.Unicode.GetBytes(Environment.MachineName + " > " + txt_Message.Text);

            foreach (Socket s in asoc)
            {
                s.Send(bmsg);
            }
            lst_Message.Items.Add(Environment.MachineName + " > " + txt_Message.Text);
            txt_Message.Text = "";
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void btn_SendSelectClient_Click(object sender, EventArgs e)
        {
            if (lst_ClientList.SelectedIndex >= 0)
            {
                string SelectItem = lst_ClientList.SelectedItem.ToString();
                string Ip = SelectItem.Substring(0, SelectItem.IndexOf(":"));
                string port = SelectItem.Substring(SelectItem.IndexOf(":") + 1, SelectItem.Length - SelectItem.IndexOf(":") - 1);
                IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(Ip), int.Parse(port));
                MyClient m = new MyClient();
                m.sendMessage(iPEndPoint, txt_Message.Text);
                lst_Message.Items.Add(Environment.MachineName + " > " + txt_Message.Text);
                txt_Message.Text = "";
            }
        }
        private void txt_Message_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_SendAll.Focus();
            }
        }
    }
}
