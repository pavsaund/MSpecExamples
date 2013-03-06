using System;

namespace Source
{
    public class BananaShop : IBananaShop
    {
        public BananaShop()
        {
            BananasInCart = 0;
        }

        public void BuyBanana()
        {
            BananasInCart++;
        }

        public int BananasInCart { get; set; }
    }
}