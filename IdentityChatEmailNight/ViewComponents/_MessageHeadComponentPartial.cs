using Microsoft.AspNetCore.Mvc;

namespace IdentityChatEmailNight.ViewComponents
{
    public class _MessageHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
