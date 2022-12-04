using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using System.Threading.Tasks;

namespace IdentityChatApplication.Controllers
{
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;
        private readonly IAppUserService _appUserService;
        private readonly UserManager<AppUser> _userManager;

        public MessageController(IMessageService messageService, UserManager<AppUser> userManager, IAppUserService appUserService)
        {
            _messageService = messageService;
            _userManager = userManager;
            _appUserService = appUserService;
        }
     

        public async Task<IActionResult> Index(AppUser appUser)
        {
            var username = User.Identity.Name;
            var loggedUserValues = _appUserService.getLoggedUserID(username);
            ViewBag.imageUrl = loggedUserValues.ImageUrl;
            ViewBag.NameSurname = loggedUserValues.Name + " " + loggedUserValues.Surname;
          
            
            return View(appUser);//seçim yapılan kişinin bilgilerini Index view'ine gönderiyor.
        }
        public IActionResult GetSelectedPersonInformations(int ID)

        {
            var values = _appUserService.TGetByID(ID);//seçim yapılan kişinin bilgilerini Index view'ine gönderiyor.


            return View("Index", values);

        }
    }
}
