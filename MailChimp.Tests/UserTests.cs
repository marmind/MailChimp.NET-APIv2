using System.Collections.Generic;
using System.Linq;
using MailChimpApiV2.Users;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimpApiV2.Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void GetLogins_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            //  Act
            List<UserLoginsResult> details = mc.GetLogins();

            //  Assert
            Assert.IsTrue(details.Any());
        }

        [TestMethod]
        public void GetProfile_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            //  Act
            UserProfile details = mc.GetUserProfile();

            //  Assert
            Assert.IsFalse(string.IsNullOrEmpty(details.AccountName));
        }
    }
}
