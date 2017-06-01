using RemotingObject;
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows.Forms;

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
            RemotingConfiguration.RegisterWellKnownClientType(typeof(Profile), "tcp://localhost:1234/IProfile");
            profile = new Profile();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSetCustomer_Click(object sender, EventArgs e)
        {
            profile.SetProfile(txtCustomername.Text, txtLocation.Text);
        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            customer = profile.GetCustomer();
            lblCustomername.Text = customer.Customername;
        }
    }
}
