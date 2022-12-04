using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace IdentityChatApplication.ViewComponents.SendMessage
{
	public class _SendMessage:ViewComponent
	{
        private readonly IMessageDal _messageDal;

        public _SendMessage(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public IViewComponentResult Invoke(Message message,int userID)
        {
            if (userID != 0)
            {
                message.ReceiverID = userID;
                message.messageDate = System.DateTime.Now;
                _messageDal.Insert(message);

            }
            
                

            return View();
        }
    }
}
