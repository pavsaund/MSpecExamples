using Machine.Specifications;
using Source;
using It = Machine.Specifications.It;

namespace Specs.for_FakeService
{
    public class when_a_user_buys_a_banana_from_the_bananashop
    {
        static IBananaShop shop;

        Establish context = () =>
            {
                shop = new BananaShop();
                
            };

        Because of = () => shop.BuyBanana();

        It should_add_a_banana_to_the_cart = () => shop.BananasInCart.ShouldEqual(1);
    }
}
