using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace IdentityChatApplication.ViewComponents.MyChatPerson
{
	public class _MyChatPerson:ViewComponent
	{
        private readonly IFriendlistService _friendlistService;
        private readonly IAppUserService _appUserService;

        public _MyChatPerson(IFriendlistService friendlistService, IAppUserService appUserService)
        {
            _friendlistService = friendlistService;
            _appUserService = appUserService;
        }

        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            var loggedUserValues = _appUserService.getLoggedUserID(username);
           
            var values = _friendlistService.GetFriendlist(loggedUserValues.Id);

            return View(values);
        }
    }
}
