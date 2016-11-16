using Moq;
using NUnit.Framework;
using PricingServiceWeb.Data.Model;

namespace PricingServiceWeb.Data.Tests
{
    [TestFixture]
    public class TestClass
    {
        Moq.Mock<IProductOperation> mock = new Moq.Mock<IProductOperation>();
        IProductOperation productOps = new ProductOperation();
        [SetUp]
        public void ObjectCreation()
        {
            IProductOperation productOperation = mock.Object;
        }

        [Test]
        public void Check_For_Function_Call()
        {
            mock.Verify(t => t.Update(It.IsAny<AdjustPrice>()));
        }
        [TearDown]
        public void Instance_Release()
        {
            IProductOperation productOperation = null;
        }


    }
}
