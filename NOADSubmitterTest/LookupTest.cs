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
            var AgencyLookup = new AgencyListLookupDAO().FetchLookup();
            Assert.IsNotNull(AgencyLookup);

            var CDCClassLookup = new CDCClassListDAO().FetchLookup();
            Assert.IsNotNull(CDCClassLookup);

            var CountryLookup = new CountryListDAO().FetchLookup();
            Assert.IsNotNull(CountryLookup);

            var CrewTypeLookup = new CrewTypeListDAO().FetchLookup();
            Assert.IsNotNull(CrewTypeLookup);

            var ForeignPortLookup = new ForiegnPortListDAO().FetchLookup();
            Assert.IsNotNull(ForeignPortLookup);

            var INAExemptionsLookup = new INAExemptionsListDAO().FetchLookup();
            Assert.IsNotNull(INAExemptionsLookup);

            var InterimISSCLookup = new InterimISSCTypeListDAO().FetchLookup();
            Assert.IsNotNull(InterimISSCLookup);

            var PersonIdTypeLookup = new PersonIdTypeDAO().FetchLookup();
            Assert.IsNotNull(PersonIdTypeLookup);

            var StateLookup = new StateListDAO().FetchLookup();
            Assert.IsNotNull(StateLookup);

            var ShipIdTypeLookup = new ShipIdTypeListDAO().FetchLookup();
            Assert.IsNotNull(ShipIdTypeLookup);

            var VesselClassificationLookup = new VesselClassificationListDAO().FetchLookup();
            Assert.IsNotNull(VesselClassificationLookup);
        }
    }
}
