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

namespace RemotingClient
{
    public partial class Client : Form
    {

        Profile profile;
        Customer customer;

        public Client()
        {
            InitializeComponent();
            lblCustomername.Text = String.Empty;

            TcpClientChannel channel = new TcpClientChannel();
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterActivatedClientType(typeof(Profile), "tcp://localhost:1234");

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSetCustomer_Click(object sender, EventArgs e)
        {
            profile = new Profile();
            profile.SetProfile(txtCustomername.Text);
        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            if (profile == null)
                profile = new Profile();

            customer = profile.GetCustomer();
            lblCustomername.Text = customer.Customername;
        }
    }
}
