using RabbitRegister.Model;
using RabbitRegister.Services.RabbitService;
using RabbitRegister.Services.TrimmingService;

namespace Test1
{
    [TestClass]
    public class UnitTest1
    {
        private RabbitService _rabbitService;

        [TestInitialize]
        public void Initialize()
        {
            _rabbitService = new RabbitService();
        }


        [TestMethod]
        public void Test_GetAllRabbits()
        {
            int count = _rabbitService.GetAllRabbits().Count;

            Assert.IsTrue(count == 8);
        }

        [TestMethod]
        public void Test_GetRabbit()
        {
            Rabbit rabbit = _rabbitService.GetRabbit(1, 5095);

            Assert.IsNotNull(rabbit);
        }


    }
}