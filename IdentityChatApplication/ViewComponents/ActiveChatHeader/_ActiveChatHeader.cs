using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace IdentityChatApplication.ViewComponents.ActiveChatHeader
{
	public class _ActiveChatHeader:ViewComponent
	{
        public IViewComponentResult Invoke(AppUser appUser)
        {
            //Index'ten gönderilen seçim yapılan kişinin bilgileri view componente gidiyor
            if (appUser == null)
            {
                return View();
            }
            else
            {
                return View(appUser);

            }
            


            
        }
    }
}
