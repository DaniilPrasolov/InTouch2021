using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InTouch2021.Controllers
{
    public class FeedBackController : Controller
    {
        public IActionResult FeedBack()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitAsync()
        {
            EmailService emailService = new EmailService();
            await emailService.SendEmailAsync("intouch2021@mail.ru", "Тема письма", "Тест письма: тест!");
            return View("FeedBack");
        }
    }
}
