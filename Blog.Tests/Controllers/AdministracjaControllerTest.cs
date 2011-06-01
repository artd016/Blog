using Blog.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Web.Mvc;
using Blog.Models;

namespace Blog.Tests
{
    
    
    /// <summary>
    ///This is a test class for AdministracjaControllerTest and is intended
    ///to contain all AdministracjaControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AdministracjaControllerTest
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
        ///A test for AdministracjaController Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Documents and Settings\\SQL\\Pulpit\\Blog\\Blog\\Blog", "/")]
        [UrlToTest("http://localhost:1032/")]
        public void AdministracjaControllerConstructorTest()
        {
            AdministracjaController target = new AdministracjaController();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Documents and Settings\\SQL\\Pulpit\\Blog\\Blog\\Blog", "/")]
        [UrlToTest("http://localhost:1032/")]
        public void DeleteTest()
        {
            AdministracjaController target = new AdministracjaController(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            FormCollection collection = null; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Delete(id, collection);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Documents and Settings\\SQL\\Pulpit\\Blog\\Blog\\Blog", "/")]
        [UrlToTest("http://localhost:1032/")]
        public void DeleteTest1()
        {
            AdministracjaController target = new AdministracjaController(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Delete(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DodajKom
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Documents and Settings\\SQL\\Pulpit\\Blog\\Blog\\Blog", "/")]
        [UrlToTest("http://localhost:1032/")]
        public void DodajKomTest()
        {
            AdministracjaController target = new AdministracjaController(); // TODO: Initialize to an appropriate value
            Komentarze nkom = null; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.DodajKom(nkom);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DodajKom
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Documents and Settings\\SQL\\Pulpit\\Blog\\Blog\\Blog", "/")]
        [UrlToTest("http://localhost:1032/")]
        public void DodajKomTest1()
        {
            AdministracjaController target = new AdministracjaController(); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.DodajKom();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DodajPost
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Documents and Settings\\SQL\\Pulpit\\Blog\\Blog\\Blog", "/")]
        [UrlToTest("http://localhost:1032/")]
        public void DodajPostTest()
        {
            AdministracjaController target = new AdministracjaController(); // TODO: Initialize to an appropriate value
            Post collection = null; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.DodajPost(collection);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DodajPost
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Documents and Settings\\SQL\\Pulpit\\Blog\\Blog\\Blog", "/")]
        [UrlToTest("http://localhost:1032/")]
        public void DodajPostTest1()
        {
            AdministracjaController target = new AdministracjaController(); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.DodajPost();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Edit
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Documents and Settings\\SQL\\Pulpit\\Blog\\Blog\\Blog", "/")]
        [UrlToTest("http://localhost:1032/")]
        public void EditTest()
        {
            AdministracjaController target = new AdministracjaController(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            FormCollection collection = null; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Edit(id, collection);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Edit
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Documents and Settings\\SQL\\Pulpit\\Blog\\Blog\\Blog", "/")]
        [UrlToTest("http://localhost:1032/")]
        public void EditTest1()
        {
            AdministracjaController target = new AdministracjaController(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Edit(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Index
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Documents and Settings\\SQL\\Pulpit\\Blog\\Blog\\Blog", "/")]
        [UrlToTest("http://localhost:1032/")]
        public void IndexTest()
        {
            AdministracjaController target = new AdministracjaController(); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Index();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Post
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Documents and Settings\\SQL\\Pulpit\\Blog\\Blog\\Blog", "/")]
        [UrlToTest("http://localhost:1032/")]
        public void PostTest()
        {
            AdministracjaController target = new AdministracjaController(); // TODO: Initialize to an appropriate value
            int year = 0; // TODO: Initialize to an appropriate value
            int month = 0; // TODO: Initialize to an appropriate value
            int day = 0; // TODO: Initialize to an appropriate value
            string id = string.Empty; // TODO: Initialize to an appropriate value
            int page = 0; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Post(year, month, day, id, page);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PostyOznaczoneTagiem
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Documents and Settings\\SQL\\Pulpit\\Blog\\Blog\\Blog", "/")]
        [UrlToTest("http://localhost:1032/")]
        public void PostyOznaczoneTagiemTest()
        {
            AdministracjaController target = new AdministracjaController(); // TODO: Initialize to an appropriate value
            string id = string.Empty; // TODO: Initialize to an appropriate value
            int page = 0; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.PostyOznaczoneTagiem(id, page);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Szukaj
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Documents and Settings\\SQL\\Pulpit\\Blog\\Blog\\Blog", "/")]
        [UrlToTest("http://localhost:1032/")]
        public void SzukajTest()
        {
            AdministracjaController target = new AdministracjaController(); // TODO: Initialize to an appropriate value
            string zapytanie = string.Empty; // TODO: Initialize to an appropriate value
            int page = 0; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Szukaj(zapytanie, page);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Tagi
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Documents and Settings\\SQL\\Pulpit\\Blog\\Blog\\Blog", "/")]
        [UrlToTest("http://localhost:1032/")]
        public void TagiTest()
        {
            AdministracjaController target = new AdministracjaController(); // TODO: Initialize to an appropriate value
            Tagi collection = null; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Tagi(collection);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UsunKom
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Documents and Settings\\SQL\\Pulpit\\Blog\\Blog\\Blog", "/")]
        [UrlToTest("http://localhost:1032/")]
        public void UsunKomTest()
        {
            AdministracjaController target = new AdministracjaController(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.UsunKom(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WysKomentarze
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Documents and Settings\\SQL\\Pulpit\\Blog\\Blog\\Blog", "/")]
        [UrlToTest("http://localhost:1032/")]
        public void WysKomentarzeTest()
        {
            AdministracjaController target = new AdministracjaController(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            int page = 0; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.WysKomentarze(id, page);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WyswietlPosty
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Documents and Settings\\SQL\\Pulpit\\Blog\\Blog\\Blog", "/")]
        [UrlToTest("http://localhost:1032/")]
        public void WyswietlPostyTest()
        {
            AdministracjaController target = new AdministracjaController(); // TODO: Initialize to an appropriate value
            int page = 0; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.WyswietlPosty(page);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for lista
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Documents and Settings\\SQL\\Pulpit\\Blog\\Blog\\Blog", "/")]
        [UrlToTest("http://localhost:1032/")]
        public void listaTest()
        {
            AdministracjaController target = new AdministracjaController(); // TODO: Initialize to an appropriate value
            SelectList expected = null; // TODO: Initialize to an appropriate value
            SelectList actual;
            actual = target.lista();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
