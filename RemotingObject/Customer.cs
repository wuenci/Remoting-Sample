using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingObject
{
    
    public class Customer : MarshalByRefObject
    {
        private string customername;
        private string location;

        
        public Customer(string customername)
        {
            this.customername = customername;
            this.location = String.Empty;
        }

        public string Customername
        {
            get { return this.customername; }
            set { this.customername = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

    }
}
