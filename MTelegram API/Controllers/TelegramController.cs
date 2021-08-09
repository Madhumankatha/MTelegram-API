using MTelegram_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Telegram.Bot;

namespace MTelegram_API.Controllers
{
    public class TelegramController : Controller
    {
        // GET: Telegram
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(MTelegram telegram )
        {
            var bot = new TelegramBotClient("1930703905:AAHWBR3ea5ZzRHgMRj4CVBuEuYdgKh9gXhM");

            await bot.SendTextMessageAsync(
                chatId: "@asp_net_18",
                text: "You Said : " + telegram.Message
            );

            return View();
        }


    }
}