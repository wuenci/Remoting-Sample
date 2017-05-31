using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingObject
{
    public interface IProfile
    {
        void SetProfile(string customername);
        Customer GetCustomer();
    }
}
