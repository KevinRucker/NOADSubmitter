using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NOADSubmitter.Data.Repository;

namespace NOADSubmitterTest
{
    /// <summary>
    /// Summary description for AgencyListLookupTest
    /// </summary>
    [TestClass]
    public class LookupTest
    {
        public LookupTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

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
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            var stopwatch = new Stopwatch();
            var totalWatch = new Stopwatch();

            stopwatch.Start();
            totalWatch.Start();
            var AgencyLookup = new AgencyListLookupDAO().FetchLookup();
            stopwatch.Stop();
            totalWatch.Stop();
            LogTime(stopwatch, "Agency List: ");
            Assert.IsNotNull(AgencyLookup);

            stopwatch.Start();
            totalWatch.Start();
            var CDCClassLookup = new CDCClassListDAO().FetchLookup();
            stopwatch.Stop();
            totalWatch.Stop();
            LogTime(stopwatch, "CDC Class List: ");
            Assert.IsNotNull(CDCClassLookup);

            stopwatch.Start();
            totalWatch.Start();
            var CountryLookup = new CountryListDAO().FetchLookup();
            stopwatch.Stop();
            totalWatch.Stop();
            LogTime(stopwatch, "Country List: ");
            Assert.IsNotNull(CountryLookup);

            stopwatch.Start();
            totalWatch.Start();
            var CrewTypeLookup = new CrewTypeListDAO().FetchLookup();
            stopwatch.Stop();
            LogTime(stopwatch, "Crew Type List: ");
            Assert.IsNotNull(CrewTypeLookup);

            stopwatch.Start();
            totalWatch.Start();
            var ForeignPortLookup = new ForiegnPortListDAO().FetchLookup();
            stopwatch.Stop();
            totalWatch.Stop();
            LogTime(stopwatch, "Foreign Port List: ");
            Assert.IsNotNull(ForeignPortLookup);

            stopwatch.Start();
            totalWatch.Start();
            var INAExemptionsLookup = new INAExemptionsListDAO().FetchLookup();
            stopwatch.Stop();
            totalWatch.Stop();
            LogTime(stopwatch, "INA Exemptions List: ");
            Assert.IsNotNull(INAExemptionsLookup);

            stopwatch.Start();
            totalWatch.Start();
            var InterimISSCLookup = new InterimISSCTypeListDAO().FetchLookup();
            stopwatch.Stop();
            totalWatch.Stop();
            LogTime(stopwatch, "Interim ISSC Type List: ");
            Assert.IsNotNull(InterimISSCLookup);

            stopwatch.Start();
            totalWatch.Start();
            var PersonIdTypeLookup = new PersonIdTypeDAO().FetchLookup();
            stopwatch.Stop();
            totalWatch.Stop();
            LogTime(stopwatch, "Person Id Type List: ");
            Assert.IsNotNull(PersonIdTypeLookup);

            stopwatch.Start();
            totalWatch.Start();
            var StateLookup = new StateListDAO().FetchLookup();
            stopwatch.Stop();
            totalWatch.Stop();
            LogTime(stopwatch, "State List: ");
            Assert.IsNotNull(StateLookup);

            stopwatch.Start();
            totalWatch.Start();
            var ShipIdTypeLookup = new ShipIdTypeListDAO().FetchLookup();
            stopwatch.Stop();
            totalWatch.Stop();
            LogTime(stopwatch, "Ship Id Type List: ");
            Assert.IsNotNull(ShipIdTypeLookup);

            stopwatch.Start();
            totalWatch.Start();
            var VesselClassificationLookup = new VesselClassificationListDAO().FetchLookup();
            stopwatch.Stop();
            totalWatch.Stop();
            LogTime(stopwatch, "Vessel Classification List: ");
            LogTime(totalWatch, "Total Time: ");
            Assert.IsNotNull(VesselClassificationLookup);
        }

        private static void LogTime(Stopwatch watch, string description)
        {
            System.Console.WriteLine(description + watch.Elapsed.ToString());
            watch.Reset();
        }
    }
}
