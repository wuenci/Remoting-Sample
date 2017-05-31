using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingObject
{
    public class Profile : MarshalByRefObject
    {
        private Customer customer;

        public Profile()
        {
            customer = new Customer("InitPerson");
        }

        public void SetProfile(string customername)
        {
            customer.Customername = customername;
        }

        public Customer GetCustomer()
        {
            return customer;
        }
    }
}
