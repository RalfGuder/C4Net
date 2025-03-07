using C4Net.Core.IoC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tests.C4Net.Core.IoC.TestClasses;
using System.Threading;

namespace Tests.C4Net.Core
{
    
    
    /// <summary>
    ///This is a test class for InversionItemTest and is intended
    ///to contain all InversionItemTest Unit Tests
    ///</summary>
    [TestClass()]
    public class InversionItemTest
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
        ///A test for InversionItem Constructor
        ///</summary>
        [TestMethod()]
        public void InversionItemConstructorTest()
        {
            Type interfaceType = typeof(ITestIoc);
            Type objectType = typeof(TestIoc);
            InversionLifetime lifetime = InversionLifetime.PerCall;
            InversionItem target = new InversionItem(interfaceType, objectType, lifetime);
            Assert.AreEqual(target.InterfaceType, interfaceType);
            Assert.AreEqual(target.ObjectType, objectType);
            Assert.AreEqual(target.Lifetime, lifetime);
            Assert.AreEqual(target.Expiration, InversionExpiration.Never);
            lifetime = InversionLifetime.PerToken;
            target = new InversionItem(interfaceType, objectType, lifetime);
            Assert.AreEqual(target.InterfaceType, interfaceType);
            Assert.AreEqual(target.ObjectType, objectType);
            Assert.AreEqual(target.Lifetime, lifetime);
            Assert.AreEqual(target.Expiration, InversionExpiration.Never);
            lifetime = InversionLifetime.Singleton;
            target = new InversionItem(interfaceType, objectType, lifetime);
            Assert.AreEqual(target.InterfaceType, interfaceType);
            Assert.AreEqual(target.ObjectType, objectType);
            Assert.AreEqual(target.Lifetime, lifetime);
            Assert.AreEqual(target.Expiration, InversionExpiration.Never);
        }

        /// <summary>
        ///A test for InversionItem Constructor
        ///</summary>
        [TestMethod()]
        public void InversionItemConstructorTest1()
        {
            Type interfaceType = typeof(ITestIoc);
            object instance = new TestIoc();
            InversionItem target = new InversionItem(interfaceType, instance);
            Assert.AreEqual(target.InterfaceType, interfaceType);
            Assert.AreEqual(target.ObjectType, instance.GetType());
            Assert.AreEqual(target.Lifetime, InversionLifetime.Singleton);
            Assert.AreEqual(target.Expiration, InversionExpiration.Never);
        }

        /// <summary>
        ///A test for CheckExpiration
        ///</summary>
        [TestMethod()]
        public void CheckExpirationTest()
        {
            Type interfaceType = typeof(ITestIoc);
            object instance = new TestIoc();
            InversionItem target = new InversionItem(interfaceType, instance);
            Assert.AreEqual(target.GetObject(), instance);
            target.Expiration = InversionExpiration.Idle;
            target.ExpireSpan = new TimeSpan(0,0,0,0,50);
            Assert.AreEqual(target.GetObject(), instance);
            Thread.Sleep(40);
            target.CheckExpiration();
            Assert.AreEqual(target.GetObject(), instance, "Item must not be expired");
            Thread.Sleep(60);
            target.CheckExpiration();
            Assert.AreNotEqual(target.GetObject(),instance, "Item must be expired");
        }

        /// <summary>
        ///A test for ExistsToken
        ///</summary>
        [TestMethod()]
        public void ExistsTokenTest()
        {
            Type interfaceType = typeof(ITestIoc);
            Type objectType = typeof(TestIoc);
            InversionLifetime lifetime = InversionLifetime.PerToken;
            InversionItem target = new InversionItem(interfaceType, objectType, lifetime);
            target.GetObject("A");
            target.GetObject("B");
            Assert.IsTrue(target.ExistsToken("A"), "Token A must exists");
            Assert.IsTrue(target.ExistsToken("B"), "Token B must exists");
            Assert.IsFalse(target.ExistsToken("C"), "Token C must not exists");
        }

        /// <summary>
        ///A test for GetObject
        ///</summary>
        [TestMethod()]
        public void GetObjectTest()
        {
            Type interfaceType = typeof(ITestIoc);
            Type objectType = typeof(TestIoc);
            InversionLifetime lifetime = InversionLifetime.PerToken;
            InversionItem target = new InversionItem(interfaceType, objectType, lifetime);
            Assert.IsNotNull(target.GetObject("A"), "Token A must exists");

        }
    }
}
