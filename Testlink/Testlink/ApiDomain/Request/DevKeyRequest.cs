using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testlink.ApiDomain.Request
{
    public class DevKeyRequest
    {
        [XmlRpcMember("devKey")]
        public string devKey;

        public DevKeyRequest(string _devKey)
        {
            devKey = _devKey;
        }
    }
}
