using EI.SI;
using Pagina_Registo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Cliente : Form
    {
        private const int PORT = 10000;
        NetworkStream networkStream;
        ProtocolSI protocolSI;
        TcpClient client;
        public Cliente()
        {
            InitializeComponent();
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Loopback, PORT);
            client = new TcpClient();

            client.Connect(endpoint);
            networkStream = client.GetStream();
            protocolSI = new ProtocolSI();
        }

        private void tbEnviarmensagem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviarMensagem_Click(object sender, EventArgs e)
        {
            string msg = tbEnviarmensagem.Text;
            tbEnviarmensagem.Clear();
            byte[] packet = protocolSI.Make(ProtocolSICmdType.DATA, msg);
            networkStream.Write(packet, 0, packet.Length);
            while (protocolSI.GetCmdType() != ProtocolSICmdType.ACK)
            {
                networkStream.Read(protocolSI.Buffer, 0, protocolSI.Buffer.Length);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            byte[] eot = protocolSI.Make(ProtocolSICmdType.EOT);
            networkStream.Write(eot, 0, eot.Length);
            networkStream.Read(protocolSI.Buffer, 0, protocolSI.Buffer.Length);
            networkStream.Close();
            client.Close();
            this.Close();
        }

        private void btnEnviarficheiro_Click(object sender, EventArgs e)
        {
            OFD1.ShowDialog();
            string filename = OFD1.FileName;
            string readfile = File.ReadAllText(filename);

            string msg = filename;
            tbEnviarmensagem.Clear();
            byte[] packet = protocolSI.Make(ProtocolSICmdType.DATA, msg);
            networkStream.Write(packet, 0, packet.Length);
            while (protocolSI.GetCmdType() != ProtocolSICmdType.ACK)
            {
                networkStream.Read(protocolSI.Buffer, 0, protocolSI.Buffer.Length);
            }
        }

        private void OFD1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formautenticacao interligar = new Formautenticacao();
            interligar.ShowDialog();
        }
    }
}
