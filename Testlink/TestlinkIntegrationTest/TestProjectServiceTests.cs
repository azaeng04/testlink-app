using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testlink.ApiDomain.Response;
using Testlink.ApiService;

namespace TestlinkIntegrationTest
{
    [TestFixture]
    public class TestProjectServiceTests
    {
        [Test]
        public void GetTestProjects()
        {
            //Arrange
            TestProjectService ProjectService = TestProjectService.Create("f12ac21bf0d791aaed8d653defdf8667");

            //Act
            TestProjectResponse[] testProjects = ProjectService.GetProjects();

            //Assert
            Assert.IsNotNull(testProjects);

            foreach (var testProject in testProjects)
            {
                Console.WriteLine($"Test Project ID: {testProject.Id}\nTest Project Name: {testProject.Name}");
            }
        }
    }
}
