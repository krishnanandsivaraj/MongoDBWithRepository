using NUnit.Framework;
using MongDbSample.Data;
using Moq;
using MongDbSample.Data.Model;

namespace ProductCatalogueWeb.Data.Tests
{
    [TestFixture]
    public class TestClass
    {
        Moq.Mock<IRepository> mock = new Moq.Mock<IRepository>();
        IRepository productOps = new ProductInformation();
        [SetUp]
        public void ObjectCreation()
        {
            IRepository productOperation = mock.Object;
        }

        [Test]
        public void Check_For_Function_Call()
        {
            mock.Verify(t => t.Update(It.IsAny<Products>()));
        }
        [TearDown]
        public void Instance_Release()
        {
            IRepository productOperation = null;
        }
    }
}
