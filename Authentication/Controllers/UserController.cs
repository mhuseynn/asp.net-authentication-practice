using Authentication.Models;
using Authentication.Services;
using Authentication.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Authentication.Controllers;

public class UserController : Controller
{


    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = DataBase.Users!.FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);
            if (user != null)
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Invalid username or password.");
            
        }
        return View(model);
    }

    [HttpGet]
    public IActionResult Registration()
    {

        return View();
    }


    [HttpPost]
    public IActionResult Registration(RegistrationViewModel viewModel)
    {

        if (ModelState.IsValid)
        {
            var config = new MapperConfiguration(c =>
                c.CreateMap<RegistrationViewModel, User>()
            );

            var mapper = new Mapper(config);



            var user = new User();


            user = mapper.Map<User>(viewModel);

            DataBase.Users!.Add(user);

            return RedirectToAction("Login");

        }

        return View(viewModel);
    }

}
