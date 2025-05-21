using IdentityChatEmailNight.Context;
using IdentityChatEmailNight.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

public class ProfileController : Controller
{
    private readonly EmailContext _context;
    private readonly UserManager<AppUser> _userManager;

    public ProfileController(EmailContext context, UserManager<AppUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public async Task<IActionResult> ProfileDetail()
    {
        var values = await _userManager.FindByNameAsync(User.Identity.Name);
        ViewBag.name = values.Name;
        ViewBag.surname = values.Surname;
        ViewBag.email = values.Email;
        ViewBag.phone = values.PhoneNumber;
        ViewBag.RecipientEmailAddressCount = _context.Messages
                              .Where(x => x.ReceiverEmail == values.Email)
                              .Count();

        ViewBag.SenderEmailAddressCount = _context.Messages
                                             .Where(x => x.SenderEmail == values.Email)
                                             .Count();

        return View(values);
    }

    [HttpPost]
    public async Task<IActionResult> ProfileUpdate(AppUser updatedUser)
    {
        var user = await _userManager.FindByNameAsync(User.Identity.Name);
        user.Name = updatedUser.Name;
        user.Surname = updatedUser.Surname;
        user.PhoneNumber = updatedUser.PhoneNumber;
        user.ProfileImageUrl = updatedUser.ProfileImageUrl;
        user.Email = updatedUser.Email;

        await _userManager.UpdateAsync(user);
        _context.SaveChanges();

        return RedirectToAction("ProfileDetail");

    }

}