﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Shop.Views.Account
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}