using AutoMapper.Internal;
using EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using TraversalCoreDemo.Models;

namespace TraversalCoreDemo.Controllers
{
    [AllowAnonymous]
    public class PasswordChangeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public PasswordChangeController(UserManager<AppUser> userManager)
        {
            this._userManager = userManager;
        }

        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel forgetPasswordViewModel)
        {
            var user = await _userManager.FindByEmailAsync(forgetPasswordViewModel.Mail);
            string usertoken = await _userManager.GeneratePasswordResetTokenAsync(user);
            var passwordresettoken = Url.Action("ResetPassword", "PasswordChange", new
            {
                userId = user.Id,
                token = usertoken
            },HttpContext.Request.Scheme);
            
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "salimberk2@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", forgetPasswordViewModel.Mail);
            mimeMessage.To.Add(mailboxAddressTo);
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = passwordresettoken;
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = "Şifre Değişiklik Talwbi";
            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("salimberk2@gmail.com", "Ssberk123");
            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }
        [HttpGet]
        public IActionResult ResetPassword(string userid,string token) {
            TempData["userId"] = userid;
            TempData["token"] = token;

            return View(); 
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
        {
            var userid = TempData["userId"];
            var token = TempData["token"];
            if(userid == null || token==null)
            {

            }
            var user = await _userManager.FindByIdAsync(userid.ToString());
            var result = await _userManager.ResetPasswordAsync(user, token, resetPasswordViewModel.Password);
            if(result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }

            return View();
        }

    }
}
