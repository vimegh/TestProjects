using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TCMPropertiesProject
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext m_testContext;

        public TestContext TestContext
        {
            get { return m_testContext; }

            set { m_testContext = value; }
        }

        [TestMethod]
        public void TestTCMPropertiesExist()
        {
            string TfsTeamProject = (string)TestContext.Properties["__Tfs_TeamProject__"];
            Assert.IsFalse(string.IsNullOrEmpty(TfsTeamProject));

            string TfsServerCollectionUrl = (string)TestContext.Properties["__Tfs_TfsServerCollectionUrl__"];
            Assert.IsFalse(string.IsNullOrEmpty(TfsServerCollectionUrl));

            string BuildUri = (string)TestContext.Properties["__Tfs_BuildUri__"];
            Assert.IsFalse(string.IsNullOrEmpty(BuildUri));

            int TestRunId = (int)TestContext.Properties["__Tfs_TestRunId__"];
            Assert.IsFalse(TestRunId == 0);

            int TestPlanId = (int)TestContext.Properties["__Tfs_TestPlanId__"];
            Assert.IsFalse(TestPlanId == 0);

            int TestCaseId = (int)TestContext.Properties["__Tfs_TestCaseId__"];
            Assert.IsFalse(TestCaseId == 0);

            int TestPointId = (int)TestContext.Properties["__Tfs_TestPointId__"];
            Assert.IsFalse(TestPointId == 0);

            bool IsInLabEnvironment = (bool)TestContext.Properties["__Tfs_IsInLabEnvironment__"];
            Assert.IsFalse(IsInLabEnvironment);
        }
    }
}
