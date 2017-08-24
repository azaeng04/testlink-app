using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testlink.ApiDomain.Response
{
    public class TestProjectResponse
    {
        [XmlRpcMember("id")]
        public string Id { get; set; }

        [XmlRpcMember("name")]
        public string Name { get; set; }

        [XmlRpcMember("notes")]
        public string Notes { get; set; }

        [XmlRpcMember("color")]
        public string Color { get; set; }

        [XmlRpcMember("option_reqs")]
        public string OptionRequirements { get; set; }

        [XmlRpcMember("option_priority")]
        public string OptionPriority { get; set; }

        [XmlRpcMember("option_automation")]
        public string OptionAutomation { get; set; }

        [XmlRpcMember("active")]
        public string Active { get; set; }
    }
}
