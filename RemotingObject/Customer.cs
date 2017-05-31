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

        public Customer(string customername)
        {
            this.customername = customername;
        }

        public string Customername
        {
            get { return this.customername; }
            set { this.customername = value; }
        }
        
    }
}
