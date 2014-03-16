using KafkaBusClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Kafka.Client.Tests
{
    
    
    /// <summary>
    ///This is a test class for KafkaBusConnectorTest and is intended
    ///to contain all KafkaBusConnectorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class KafkaBusConnectorTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Produce
        ///</summary>
        [TestMethod()]
        public void ProduceTest()
        {
            // ToDo: FOr load testing, get data from load test context to vary the content of this test's message:
            // http://blogs.msdn.com/b/slumley/archive/2006/05/15/passing-load-test-context-parameters-to-unit-tests.aspx

            //string message = this.TestContext.

            // Omar's Server
            string brokerAddress = "192.168.5.175";
            int brokerPort = 9092;
            string clientId = "CSharpProduceTest";
            string topicName = "LocalTest";
            int partitionId = 0;
            string data = "Test CSharp Message 04";

            //// murugan02
            //string brokerAddress = "204.151.1.25";
            //int brokerPort = 9192;
            //string clientId = "CSharpProducerTest";
            //string topicName = "page_views";
            //int partitionId = 0;
            //string data = "Hello kafka on murugan02!! Get ready for some load tests!!";


            short expected = 0; 
            short actual;
            KafkaBusConnector target = new KafkaBusConnector(brokerAddress, brokerPort, clientId);
            actual = target.Produce(topicName, partitionId, data);
            Assert.AreEqual(expected, actual);
        }
    }
}
