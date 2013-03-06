using System.Web.Mvc;
using Source;

namespace Web.Controllers
{
    public class ShopController : Controller
    {
        readonly IBananaShop _bananaShop;

        public ShopController(IBananaShop bananaShop)
        {
            _bananaShop = bananaShop;
        }

        public ActionResult ByBanana()
        {
            _bananaShop.BuyBanana();
            return RedirectToAction("Index", "Account");
        }
    }
}   