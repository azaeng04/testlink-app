using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testlink.ApiDomain.Request;
using Testlink.ApiDomain.Response;
using Testlink.ApiService.Interfaces;

namespace Testlink.ApiService
{
    public class TestProjectService
    {
        public string apiKey { get; private set; }
        private static TestProjectService _testProjectService = null;
        private TestlinkApiService TestlinkService = TestlinkApiService.Create;
        private ITestProjectService ProjectService = XmlRpcProxyGen.Create<ITestProjectService>();

        private TestProjectService(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public static TestProjectService Create(string apiKey)
        {
            if (_testProjectService == null)
            {
                _testProjectService = new TestProjectService(apiKey);
            }
            return _testProjectService;
        }

        public TestProjectResponse[] GetProjects()
        {
            if (!TestlinkService.VerifyDevKey(apiKey))
                return null;
            TestProjectResponse[] testProjects = ProjectService.GetProjects(new DevKeyRequest(apiKey));
            return testProjects;
        }
    }
}
