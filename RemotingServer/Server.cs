using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemotingObject;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace RemotingServer
{
    public partial class Server : Form
    {

        public Server()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            TcpServerChannel channel = new TcpServerChannel(1234);
            ChannelServices.RegisterChannel(channel, false);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Profile), "IProfile", WellKnownObjectMode.Singleton);


            btnStartServer.Enabled = false;

        }
    }
}
