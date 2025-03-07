using C4Net.Core.IoC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests.C4Net.Core
{
    
    
    /// <summary>
    ///This is a test class for DefaultContainerTest and is intended
    ///to contain all DefaultContainerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DefaultContainerTest
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
        ///A test for ExistsToken
        ///</summary>
        public void ExistsTokenTestHelper<T>()
        {
            string token = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = DefaultContainer.ExistsToken<T>(token);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ExistsTokenTest()
        {
            ExistsTokenTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Get
        ///</summary>
        public void GetTestHelper<T>()
        {
            string token = string.Empty; // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            actual = DefaultContainer.Get<T>(token);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetTest()
        {
            GetTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetInversionItem
        ///</summary>
        public void GetInversionItemTestHelper<TInterface>()
        {
            InversionItem expected = null; // TODO: Initialize to an appropriate value
            InversionItem actual;
            actual = DefaultContainer.GetInversionItem<TInterface>();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetInversionItemTest()
        {
            GetInversionItemTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for RegisterSingleton
        ///</summary>
        public void RegisterSingletonTestHelper<TInterface>()
        {
            TInterface instance = default(TInterface); // TODO: Initialize to an appropriate value
            DefaultContainer.RegisterSingleton<TInterface>(instance);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void RegisterSingletonTest()
        {
            RegisterSingletonTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for RegisterType
        ///</summary>
        [TestMethod()]
        public void RegisterTypeTest()
        {
            Type interfaceType = null; // TODO: Initialize to an appropriate value
            Type objectType = null; // TODO: Initialize to an appropriate value
            InversionExpiration expireMode = new InversionExpiration(); // TODO: Initialize to an appropriate value
            TimeSpan span = new TimeSpan(); // TODO: Initialize to an appropriate value
            InversionLifetime lifetime = new InversionLifetime(); // TODO: Initialize to an appropriate value
            DefaultContainer.RegisterType(interfaceType, objectType, expireMode, span, lifetime);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RegisterType
        ///</summary>
        [TestMethod()]
        public void RegisterTypeTest1()
        {
            Type interfaceType = null; // TODO: Initialize to an appropriate value
            Type objectType = null; // TODO: Initialize to an appropriate value
            InversionLifetime lifetime = new InversionLifetime(); // TODO: Initialize to an appropriate value
            DefaultContainer.RegisterType(interfaceType, objectType, lifetime);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RegisterType
        ///</summary>
        public void RegisterTypeTest2Helper<TInterface, TObject>()
        {
            InversionLifetime lifetime = new InversionLifetime(); // TODO: Initialize to an appropriate value
            DefaultContainer.RegisterType<TInterface, TObject>(lifetime);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void RegisterTypeTest2()
        {
            RegisterTypeTest2Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for RegisterType
        ///</summary>
        public void RegisterTypeTest3Helper<TInterface, TObject>()
        {
            TimeSpan span = new TimeSpan(); // TODO: Initialize to an appropriate value
            DefaultContainer.RegisterType<TInterface, TObject>(span);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void RegisterTypeTest3()
        {
            RegisterTypeTest3Helper<GenericParameterHelper, GenericParameterHelper>();
        }
    }
}
