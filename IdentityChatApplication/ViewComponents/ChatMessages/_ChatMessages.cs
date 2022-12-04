using Microsoft.AspNetCore.Mvc;

namespace IdentityChatApplication.ViewComponents.ChatMessages
{
	public class _ChatMessages : ViewComponent
	{
        public IViewComponentResult Invoke(int userID)
        {


            return View();
        }
    }
}
