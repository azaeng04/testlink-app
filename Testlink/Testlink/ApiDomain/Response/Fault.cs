using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testlink.ApiDomain.Response
{
    public class Fault
    {
        [XmlRpcMember("code")]
        public int faultCode { get; set; }
        [XmlRpcMember("message")]
        public string faultMessage { get; set; }

        public static implicit operator Fault(XmlRpcStruct val)
        {
            Fault fault = new Fault();
            foreach (var item in val.Keys)
            {
                Console.WriteLine($"{item.ToString()}");
                if (item.ToString() == "code")
                {
                    fault.faultCode = (int)val[item];
                }
                else if (item.ToString() == "message")
                {
                    fault.faultMessage = (string)val[item];
                }
            }
            return fault;
        }
    }
}
