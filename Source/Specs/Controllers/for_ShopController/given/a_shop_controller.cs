using Machine.Specifications;
using Moq;
using Source;
using Web.Controllers;

namespace Specs.Controllers.for_ShopController.given
{
    public class a_shop_controller
    {
        protected static ShopController controller;
        protected static Mock<IBananaShop> shop_mock;

        Establish context = () =>
            {
                shop_mock = new Mock<IBananaShop>();
                controller = new ShopController(shop_mock.Object);

            };
    }
}