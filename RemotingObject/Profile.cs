using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingObject
{
    public class Profile : MarshalByRefObject, IProfile
    {
        private Customer customer;

        public Profile()
        {
            customer = new Customer("InitPerson");
        }

        public void SetProfile(string customername, string location)
        {
            customer.Customername = customername;
            customer.Location = location;

            Guid g = Guid.NewGuid();

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"profile.csv", true))
            {
                file.WriteLine(g + "," + customername + "," + location);
            }
        }

        public Customer GetCustomer()
        {
            return customer;
        }
    }
}
