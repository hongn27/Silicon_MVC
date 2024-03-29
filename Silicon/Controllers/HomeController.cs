﻿using Microsoft.AspNetCore.Mvc;
using Silicon.Models.Views;

namespace Silicon.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new HomeIndexViewModel();
        ViewData["Title"] = viewModel.Title;

        return View(viewModel);
    }
}
