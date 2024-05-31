namespace Test
{
    [TestClass]
#if DEBUG
    [DeploymentItem(@"..\..\..\..\x64\Debug\Utility.dll")]
#else
    [DeploymentItem(@"..\..\..\..\x64\Release\Utility.dll")]
#endif
    public class UnitTest1
    {
        [TestMethod]
        [DeploymentItem(@"..\..\..\..\..\Data\Basic")]
        public void Basic()
        {
            // arrange
            var underTest = new Service.MyService("basic.xml");

            // act
            var type = underTest.ProductType();

            // assert
            Assert.AreEqual("Basic", type);
        }

        [TestMethod]
        [DeploymentItem(@"..\..\..\..\..\Data\Advanced")]
        public void Advanced()
        {
            // arrange
            var underTest = new Service.MyService("advanced.xml");

            // act
            var type = underTest.ProductType();

            // assert
            Assert.AreEqual("Advanced", type);
        }

        [TestMethod]
        [DeploymentItem(@"..\..\..\..\Data\Corrupted")]
        public void Corrupted()
        {
            // arrange
            var underTest = new Service.MyService("corrupted.xml");

            // act
            var type = underTest.ProductType();

            // assert
            Assert.AreEqual("<corrupted>", type);
        }
    }
}