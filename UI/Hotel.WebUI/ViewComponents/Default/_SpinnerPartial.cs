﻿using Microsoft.AspNetCore.Mvc;

namespace Hotel.WebUI.ViewComponents.Default
{
    public class _SpinnerPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
