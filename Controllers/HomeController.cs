using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TelegramBotLD.Models;

namespace TelegramBotLD.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "It's my telega bit D:";
        }
    }
}
