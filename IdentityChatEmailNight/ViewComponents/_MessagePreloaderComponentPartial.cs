using Microsoft.AspNetCore.Mvc;

namespace IdentityChatEmailNight.ViewComponents
{
    public class _MessagePreloaderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
