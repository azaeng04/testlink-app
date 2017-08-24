using CookComputing.XmlRpc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testlink;
using Testlink.ApiDomain;
using Testlink.ApiService;

namespace TestlinkIntegrationTest
{
    [TestFixture]
    public class TestlinkApiIntegrationTests
    {
        [Test]
        public void VerifyApiKey()
        {
            //Arrange
            TestlinkApiService Testlink = TestlinkApiService.Create;

            //Act
            var isValid = Testlink.VerifyDevKey("f12ac21bf0d791aaed8d653defdf8667");            

            //Assert
            Assert.IsTrue(isValid);
        }
    }
}
