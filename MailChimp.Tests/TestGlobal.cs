using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimpApiV2.Tests
{
    /// <summary>
    /// Global test information is set in this class
    /// </summary>
    [TestClass]
    public class TestGlobal
    {
        /// <summary>
        /// The global mailchimp API key
        /// </summary>
        public static string Test_APIKey = string.Empty;

        [AssemblyInitialize()]
        public static void AllTestInit(TestContext testContext)
        {
            Test_APIKey = ConfigurationManager.AppSettings["API_Key"];
        }
    }
}
