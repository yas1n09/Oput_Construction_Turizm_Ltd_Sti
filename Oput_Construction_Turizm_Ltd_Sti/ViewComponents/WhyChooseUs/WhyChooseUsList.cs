﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Oput.ViewComponents.WhyChooseUs
{
    public class WhyChooseUsList : ViewComponent
    {
        WhyChooseUsManager whyChooseUsManager = new WhyChooseUsManager(new EfWhyChooseUsDal());
        public IViewComponentResult Invoke()
        {
            var values = whyChooseUsManager.TGetList();
            return View(values);
        }
    }
}
