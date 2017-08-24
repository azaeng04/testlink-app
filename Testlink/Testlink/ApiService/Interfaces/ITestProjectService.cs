using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testlink.ApiDomain.Request;
using Testlink.ApiDomain.Response;

namespace Testlink.ApiService.Interfaces
{
    [XmlRpcUrl("http://localhost:5555/lib/api/xmlrpc/v1/xmlrpc.php")]
    public interface ITestProjectService
    {
        [XmlRpcMethod("tl.getProjects")]
        TestProjectResponse[] GetProjects(DevKeyRequest devKey);
    }
}
