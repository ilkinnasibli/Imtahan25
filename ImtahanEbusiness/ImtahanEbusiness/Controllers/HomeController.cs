﻿
using DataAccess.Contexts;
using Microsoft.AspNetCore.Mvc;


namespace ImtahanEbusiness.Controllers
{
    public class HomeController : Controller
    {
      private AppDbContext _appDbContext;
        public HomeController(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;

        }
        public IActionResult Index()
        {
            return View(_appDbContext.teams);
        }
       
    }
}