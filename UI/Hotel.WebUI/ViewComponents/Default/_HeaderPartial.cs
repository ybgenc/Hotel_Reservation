﻿using Microsoft.AspNetCore.Mvc;

namespace Hotel.WebUI.ViewComponents.Default
{
    public class _HeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
               return View();
        }
    }
}
