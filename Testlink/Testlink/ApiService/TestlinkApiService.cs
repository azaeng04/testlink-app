using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testlink.ApiDomain;
using Testlink.ApiDomain.Request;
using Testlink.ApiDomain.Response;
using Testlink.ApiService.Interfaces;

namespace Testlink.ApiService
{
    public class TestlinkApiService
    {
        public DevKeyRequest DevKey { get; private set; }
        private static TestlinkApiService _testlink = null;
        private ITestlinkApiService TestlinkService = XmlRpcProxyGen.Create<ITestlinkApiService>();

        private TestlinkApiService() { }

        public static TestlinkApiService Create
        {
            get
            {
                if (_testlink == null)
                {
                    _testlink = new TestlinkApiService();
                }
                return _testlink;
            }
        }

        public bool VerifyDevKey(string apiKey)
        {
            DevKey = new DevKeyRequest(apiKey);
            var isValid = TestlinkService.VerifyDevKey(DevKey);
            if (!typeof(bool).Equals(isValid.GetType()))
                return false;
            return true;
        }

        public bool VerifyDevKey(string apiKey, out List<Fault> faults)
        {
            DevKey = new DevKeyRequest(apiKey);
            var isValid = TestlinkService.VerifyDevKey(DevKey);
            if (typeof(XmlRpcStruct[]).Equals(isValid.GetType()))
            {
                XmlRpcStruct[] val = (XmlRpcStruct[])isValid;
                faults = new List<Fault>();
                foreach (var item in val)
                {
                    Fault fault = item;
                    faults.Add(fault);
                }
                return false;
            }
            faults = null;
            return true;
        }
    }
}
