using FethiTekyaygilWebsite.Business.ManagerFolder;
using FethiTekyaygilWebsite.Business.ManagerFolder.BasicManagerFolder;
using FethiTekyaygilWebsite.Data.POCOs;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        GenericManager<Hobby> bManager;

        [SetUp]
        public void Setup()
        {
            bManager = new GenericManager<Hobby>();
            System.Diagnostics.Debugger.Launch();
        }

        [Test]
        public void PropertyTest()
        {
            bManager.Create(new Hobby());
            //Assert.Pass();
        }
    }
}