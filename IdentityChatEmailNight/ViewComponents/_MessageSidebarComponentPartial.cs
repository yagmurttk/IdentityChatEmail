using IdentityChatEmailNight.Context;
using IdentityChatEmailNight.Entities;
using IdentityChatEmailNight.ViewComponents;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityChatEmailNight.ViewComponents
{
    public class _MessageSidebarComponentPartial : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly EmailContext _emailContext;

        public _MessageSidebarComponentPartial(UserManager<AppUser> userManager, EmailContext emailContext)
        {
            _userManager = userManager;
            _emailContext = emailContext;
        }

        public IViewComponentResult Invoke()
        {
            var user = _userManager.FindByNameAsync(User.Identity.Name).Result;

            ViewBag.ReceiveMessage = _emailContext.Messages.Count(x => x.ReceiverEmail == user.Email && x.IsRead == false);

            ViewBag.SendMessage = _emailContext.Messages.Count(x => x.SenderEmail == user.Email);

            return View();
        }
    }
}