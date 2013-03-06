using System;
using System.Web.Mvc;
using Machine.Specifications;
using Source;

namespace Specs.Controllers.for_ShopController
{
    public class when_a_user_attempts_to_buy_a_banana_when_the_shop_is_empty : given.a_shop_controller
    {
        static ActionResult result;
        static Exception exception;
        
        Establish context = () => shop_mock.Setup(s => s.BuyBanana()).Throws<DonkeyKongWasHereException>();

        Because of = () => exception = Catch.Exception(() => result = controller.ByBanana());

        It should_fall_the_app_over_in_the_users_face = () => exception.ShouldBeOfType<DonkeyKongWasHereException>();
        It should_not_give_any_feedback_to_the_user = () => result.ShouldBeNull();

    }
}