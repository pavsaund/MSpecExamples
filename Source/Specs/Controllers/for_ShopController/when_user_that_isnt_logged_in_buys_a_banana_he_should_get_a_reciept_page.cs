using System.Web.Mvc;
using Machine.Specifications;
using Moq;
using Source;
using Web.Controllers;
using It = Machine.Specifications.It;

namespace Specs.Controllers.for_ShopController
{
    public class when_user_that_isnt_logged_in_buys_a_banana_he_should_get_a_reciept_page
    {
        static ShopController controller;
        static ActionResult result;
        static Mock<IBananaShop> shop_mock;

        Establish context = () =>
            {
                shop_mock = new Mock<IBananaShop>();
                controller = new ShopController(shop_mock.Object);

            };

        Because of = () => result = controller.ByBanana();

        It should_add_the_banana_to_the_shop = () => shop_mock.Verify(sm => sm.BuyBanana(), Times.Once());
        It should_redirect_the_user = () => result.ShouldBeOfType<RedirectToRouteResult>();

    }
}
