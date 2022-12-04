using EntityLayer.Concrete;
using IdentityChatApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IdentityChatApplication.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        //Register
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        //Register
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpModel userSignUp)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    UserName = userSignUp.Username,
                    Name = userSignUp.Name,
                    Surname = userSignUp.Surname,
                    Email = userSignUp.Email,
                    PhoneNumber = userSignUp.PhoneNumber
                };

                //eğer şifreler uyuşuyorsa ona göre işlem yapsın
                var result = await _userManager.CreateAsync(appUser, userSignUp.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn", "Login");
                }
               



            }

            return View();
        }
    }
}
