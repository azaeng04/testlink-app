using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testlink.ApiDomain;
using Testlink.ApiDomain.Request;

namespace Testlink.ApiService.Interfaces
{
    [XmlRpcUrl("http://localhost:5555/lib/api/xmlrpc/v1/xmlrpc.php")]
    public interface ITestlinkApiService
    {
        [XmlRpcMethod("tl.checkDevKey")]
        object VerifyDevKey(DevKeyRequest devKey);
    }
}
