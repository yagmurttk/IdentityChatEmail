using IdentityChatEmailNight.Context;
using IdentityChatEmailNight.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityChatEmailNight.Controllers
{
    public class MessageController : Controller
    {
        private readonly EmailContext _context;
        private readonly UserManager<AppUser> _userManager;

        public MessageController(EmailContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Authorize]
        public async Task<IActionResult> Inbox(string search)
        {
            var appUser = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.email = appUser.Email;
            ViewBag.nameSurname = appUser.Name + " " + appUser.Surname;
            ViewBag.Search = search;

            var values2 = _context.Messages.Where(x => x.ReceiverEmail == appUser.Email && x.IsRead == false).ToList();

            if (!string.IsNullOrWhiteSpace(search))
            {
                values2 = values2.Where(x => x.Subject.ToLower().Contains(search.ToLower())).ToList();
             
            }

            return View(values2);
        }

        public async Task<IActionResult> Sendbox(string search)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string emailValue = values.Email;
            var sendMessageList = _context.Messages.Where(x => x.SenderEmail == emailValue).ToList();
            ViewBag.Search = search;

            return View(sendMessageList);
        }

        public IActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(Message message)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string senderEmail = values.Email;

            message.SenderEmail = senderEmail;
            message.IsRead = false;
            _context.Messages.Add(message);
            _context.SaveChanges();
            return RedirectToAction("Sendbox");
        }

        public async Task<IActionResult> MessageDetail(int id)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.senderImage = values.ProfileImageUrl;
            var value = _context.Messages.FirstOrDefault(x => x.MessageId == id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeMessageStatus(List<int> MessageId)
        {
            foreach (var id in MessageId)
            {
                var value = await _context.Messages.FindAsync(id);
                if (value.IsRead != null || value.IsRead == false)
                {
                    value.IsRead = true;

                }
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("TrashBox");
        }

        public IActionResult TrashBox()
        {
            var deletedValues = _context.Messages.Where(x => x.IsRead == true).ToList();
            return View(deletedValues);
        }
    }
}