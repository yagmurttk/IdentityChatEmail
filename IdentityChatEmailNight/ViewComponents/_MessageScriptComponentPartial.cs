using Microsoft.AspNetCore.Mvc;

namespace IdentityChatEmailNight.ViewComponents
{
    public class _MessageScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
