using BusinessLayer.Abstract.UnitOfWorkService;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreDemo.Areas.Admin.Models;

namespace TraversalCoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AccountViewModel accountViewModel)
        {
            var valuesender = _accountService.GetById(accountViewModel.SenderId);
            var valuereceiver=_accountService.GetById(accountViewModel.ReceiverId);
            valuesender.Balance -= accountViewModel.Amount;
            valuereceiver.Balance += accountViewModel.Amount;
            List<Account> modified = new List<Account>()
            {
                valuesender, valuereceiver
            };
            _accountService.multiupdate(modified);
            return View();
        }
    }
}
