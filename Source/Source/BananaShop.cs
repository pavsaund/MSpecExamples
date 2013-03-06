using System;

namespace Source
{
    public class BananaShop : IBananaShop
    {
        void IBananaShop.BuyBanana()
        {
            throw new NotImplementedException();
        }

        public int BananasInCart { get; set; }
    }
}