using Microsoft.AspNetCore.Mvc;

namespace IdentityChatEmailNight.ViewComponents
{
    public class _MessageFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}