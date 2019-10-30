using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAPP.Models;
using MyAPP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyAPP.Controllers
{
    public class AccountController : Controller
    {

        private UserContext db;
        public AccountController(UserContext context)
        {
            db = context;
        }
        
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                //User user = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password);
                User user = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email && Hash.VerifyHashedPassword(u.Password, model.Password));

                if (user != null)
                {
                    await Authenticate(model.Email);

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
                if (user == null)
                {
                    // добавляем пользователя в бд
                    db.Users.Add(new User { Email = model.Email, Password = Hash.HashPassword(model.Password), info = new UserInfo { Email = model.Email } });

                    await db.SaveChangesAsync();

                    

                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        public UserInfo GetInfo()
        {
            var selectedUserInfo = from userInfo in db.UserInfos
                                   where userInfo.Email == User.Identity.Name
                                   select userInfo;
            return selectedUserInfo.First();
        }

       

        public User GetID()
        {
            var selectedUserInfo = from user in db.Users
                                   where user.Email == User.Identity.Name
                                   select user;
            return selectedUserInfo.First();
        }

        [HttpGet]
        [Authorize]
        public IActionResult PersonalArea()
        {

            UserInfo info = GetInfo();
            ViewBag.Info = info;

            User user = GetID();
            ViewBag.id = user.Id;
            return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult ChangeInfo()
        {
            

            return View(GetInfo());
        }


        [HttpPost]
        public async Task<IActionResult> ChangeInfo(UserInfo model)
        {
            if (ModelState.IsValid)
            {

                UserInfo user = await db.UserInfos.FirstOrDefaultAsync(u => u.Email == model.Email);

                if (user != null)
                {
                    // добавляем пользователя в бд

                    user.Name = model.Name;
                    user.Surname = model.Surname;
                    user.Age = model.Age;
                    user.Address = model.Address;
                    user.About = model.About;
                   

                    await db.SaveChangesAsync();

                    return RedirectToAction("PersonalArea", "Account");
                }
                else
                    ModelState.AddModelError("", user.Email);
            }
            return View();
           
        }


        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

    }
}
