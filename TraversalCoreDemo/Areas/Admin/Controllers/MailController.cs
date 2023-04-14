using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using TraversalCoreDemo.Models;

namespace TraversalCoreDemo.Areas.Admin.Controllers
{
    public class MailController : Controller
    {
        [Area("Admin")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MailRequest mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin","salimberk2@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);
            mimeMessage.Subject=mailRequest.Subject;
            SmtpClient client= new SmtpClient();
            client.Connect("smtp.gmail.com",587,false);
            client.Authenticate("salimberk2@gmail.com", "Ssberk123");
            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }
    }
}
