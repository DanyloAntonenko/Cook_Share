﻿using Cook_Share.Models;
using Cook_Share.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Cook_Share.Controllers
{
    public class AccountController : Controller
    {
        private DataContext db;
        private readonly IHostingEnvironment _appEnvironment;
        public AccountController(DataContext context, IHostingEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
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
                User user = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email && Hash.VerifyHashedPassword(u.Password, model.Password));
                if (user != null)
                {
                    await Authenticate(model.Email); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("General", "Некорректные логин и(или) пароль");
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
                    db.Users.Add(new User { Email = model.Email, Password = Hash.HashPassword(model.Password), Name = model.Name, Surname = model.SurName });
                    await db.SaveChangesAsync();

                    await Authenticate(model.Email); // аутентификация

                    //return RedirectToAction("Index", "Home");
                    return RedirectToAction("Account", "Account");
                }
                else
                    ModelState.AddModelError("General", "Пользователь с таким электронным адресом существует");
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

        public User GetInfo()
        {
            var user = db.Users.Include(u => u.Subscriptions).Include(u => u.Subscribers).FirstOrDefault(u => u.Email == User.Identity.Name);
            return user;
        }


        public User GetInfo(int? userId)
        {
            var user = db.Users.FirstOrDefault(u => u.Id == userId);// Linq

            return user;
        }



        public IEnumerable<Publication> GetPublications(int id)
        {
            IEnumerable<Publication> publications = db.Publications.Where(c => c.UserId == id);
            return publications.Reverse();
        }

        [HttpGet]
        [Authorize]
        public IActionResult Account()
        {
            IEnumerable<PublicationPhoto> photos = db.PublicationPhotos;
            AccountModel model = new AccountModel();
            model.User = GetInfo();
            model.Publications = GetPublications(model.User.Id);
            model.Photos = photos;
            return View(model);
        }

        [HttpGet]
        [Authorize]
        public IActionResult ChangeInfo()
        {

            return View(GetInfo());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeInfo(ChangeModel model)
        {
            if (ModelState.IsValid)
            {
                string path_Root = _appEnvironment.WebRootPath;
                User user = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
                if (user != null)
                {
                    // добавляем пользователя в бд                                    
                    if ((model.Photo != null) && (model.Photo.ContentType == "image/jpeg" || model.Photo.ContentType == "image/png" || model.Photo.ContentType == "image/tiff" || model.Photo.ContentType == "image/gif" || model.Photo.ContentType == "image/bmp"))
                    {
                        string path_to_Images = path_Root + "\\img\\" + model.Photo.FileName;
                        using (var stream = new FileStream(path_to_Images, FileMode.Create))
                        {
                            await model.Photo.CopyToAsync(stream);
                        }
                        user.Photo = model.Photo.FileName;
                    }
                    else
                    {
                        user.Name = model.Name;
                        user.Surname = model.Surname;

                        await db.SaveChangesAsync();
                        return RedirectToAction("Account", "Account");
                    }
                    user.Name = model.Name;
                    user.Surname = model.Surname;

                    await db.SaveChangesAsync();

                    return RedirectToAction("Account", "Account");
                }
                else
                    ModelState.AddModelError("", user.Email);
            }
            return View();

        }
        [HttpGet]
        public IActionResult AddDish()
        {
            IEnumerable<string> cat = db.Categories.Select(c => c.Name).ToList();
            AddPublicationModel model = new AddPublicationModel();
            model.Categories = cat;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddDish(AddPublicationModel model)
        {
            string path_Root = _appEnvironment.WebRootPath;
            var photos = Request.Form.Files;
            Category Cat = await db.Categories.FirstOrDefaultAsync(c => c.Name == model.Category);
            User CurUser = GetInfo();
            List<PublicationPhoto> PubPhoto = new List<PublicationPhoto>();
            if (ModelState.IsValid)
            {
                foreach (var item in photos)
                {
                    if ((item != null) && (item.ContentType == "image/jpeg" || item.ContentType == "image/png" || item.ContentType == "image/tiff" || item.ContentType == "image/gif" || item.ContentType == "image/bmp"))
                    {
                        PublicationPhoto pb = new PublicationPhoto();
                        pb.Name = item.FileName;
                        PubPhoto.Add(pb);
                        string path_to_Images = path_Root + "\\dish_img\\" + item.FileName;
                        using (var stream = new FileStream(path_to_Images, FileMode.Create))
                        {
                            await item.CopyToAsync(stream);
                        }
                    }
                }


                db.Publications.Add(new Publication
                {
                    Time = DateTime.Now,
                    UserId = model.UserId,
                    Likes = model.Likes,
                    User = CurUser,
                    Comments = new List<Comment>(),
                    Favourites = new List<Favourites>(),
                    DishName = model.DishName,
                    CalorificVal = model.CalorificVal,
                    Cuisine = model.Cuisine,
                    CategoryId = Cat.Id,
                    Category = Cat,
                    Discription = model.Discription,
                    Recipe = model.Recipe,
                    Photos = PubPhoto
                });
                await db.SaveChangesAsync();
                return RedirectToAction("Account", "Account");
            }
            return AddDish();
            //return View(model);
            //return RedirectToAction("Account", "Account");
        }


        [HttpGet]
        public IActionResult Dish(Publication publication)
        {
            PublicationModel publicationModel = new PublicationModel();
            User user = GetInfo(publication.UserId);
            var cat = db.Categories.FirstOrDefault(c => c.Id == publication.CategoryId);
            var photos = db.PublicationPhotos.Where(p => p.PublicationId == publication.Id);
            var comments = db.Comments.Include(x => x.User).Where(c => c.PublicationId == publication.Id);
            publicationModel.Photos = photos;
            publicationModel.Publication = publication;
            publicationModel.User = user;
            publicationModel.Category = cat;
            publicationModel.Comments = comments;
            return View(publicationModel);
        }


        [HttpPost]
        public IActionResult Dish(string discription, string recipe, int id, string cuisine, int? calVal)
        {
            Publication publication = db.Publications.FirstOrDefault(c => c.Id == id);
            bool _errorDiscr = false;
            bool _errorRec = false;
            bool _errorCuis = false;
            bool _errorCal = false;
            if (recipe == null)
            {
                ModelState.AddModelError("Publication.Recipe", "Описание должно быть заполнено");
                _errorRec = true;
            }

            if (discription != null)
            {
                if (discription.Length < 2)
                {
                    ModelState.AddModelError("Publication.Discription", "Описание меньше 2 символов");
                    _errorDiscr = true;
                }
                if (discription.Length > 40)
                {
                    ModelState.AddModelError("Publication.Discription", "Описание больше 2 символов");
                    _errorDiscr = true;
                }
            }

            if (cuisine != null)
            {
                if (cuisine.Length < 2)
                {
                    ModelState.AddModelError("Publication.Cuisine", "Описание меньше 2 символов");
                    _errorCuis = true;
                }
                if (cuisine.Length > 20)
                {
                    ModelState.AddModelError("Publication.Cuisine", "Описание больше 2 символов");
                    _errorCuis = true;
                }
            }
            if (calVal != null)
            {
                if (calVal < 10)
                {
                    ModelState.AddModelError("Publication.CalorificVal", "Размер калорийности не меньше 10");
                    _errorCal = true;
                }
                if (calVal > 1500)
                {
                    ModelState.AddModelError("Publication.CalorificVal", "Размер калорийности не больше 1500");
                    _errorCal = true;
                }
            }
            if (!_errorCal)
            {
                publication.CalorificVal = calVal;
            }
            if (!_errorCuis)
            {
                publication.Cuisine = cuisine;
            }
            if (!_errorDiscr)
            {
                publication.Discription = discription;
            }
            if (!_errorRec)
            {
                publication.Recipe = recipe;
            }
            if (publication.UserId == db.Users.FirstOrDefault(u => u.Email == User.Identity.Name).Id)
            {
                db.SaveChanges();
                return Dish(publication);
            }
            return RedirectToAction("Account", "Account");
        }
        [HttpGet]
        public IActionResult ViewAllDish()
        {
            IEnumerable<Publication> publications = db.Publications
                .Include(p => p.Photos)
                .Include(p => p.User)
                .Include(p => p.Category)
                .ToList();
            return View(publications.Reverse());
        }

        [HttpPost]
        public IActionResult DeleteDish(int id)
        {
            Publication pub = db.Publications.FirstOrDefault(p => p.Id == id);
            db.Publications.Remove(pub);
            db.SaveChanges();
            return RedirectToAction("Account");
        }

        [HttpGet]
        public IActionResult UserPage(int? id)
        {
            if (id != null)
            {
                AccountModel model = new AccountModel();
                model.User = GetInfo(id);
                if (model.User.Email == User.Identity.Name)
                {
                    return RedirectToAction("Account");
                }
                IEnumerable<Subscribers> subscribers = db.Users.Include(u => u.Subscribers).FirstOrDefault(u => u.Id == id).Subscribers;

                bool issub = (subscribers.FirstOrDefault(s => s.SubUserId == GetInfo().Id)) == null ? true : false;

                IEnumerable<PublicationPhoto> photos = db.PublicationPhotos;
                model.Subscribers = subscribers;
                model.Publications = GetPublications(model.User.Id);
                model.Photos = photos;
                model.IsSub = issub;
                return View(model);
            }
            return RedirectToAction("ViewAllDish", "Account");
        }

        [HttpGet]
        public IActionResult DishPage(Publication publication)
        {

            PublicationModel publicationModel = new PublicationModel();
            User user = GetInfo(publication.UserId);
            var cat = db.Categories.FirstOrDefault(c => c.Id == publication.CategoryId);
            var photos = db.PublicationPhotos.Where(p => p.PublicationId == publication.Id);
            var comments = db.Comments.Include(x => x.User).Where(c => c.PublicationId == publication.Id);
            publicationModel.Photos = photos;
            publicationModel.Publication = publication;
            publicationModel.User = user;
            publicationModel.Category = cat;
            publicationModel.Comments = comments;
            return View(publicationModel);
        }
        public IActionResult Subscribe(int? id)
        {
            User user = GetInfo();
            IEnumerable<Subscriptions> subscriptions = db.Users.Include(u => u.Subscriptions).FirstOrDefault(u => u.Email == User.Identity.Name).Subscriptions;
            IEnumerable<Subscribers> subscribes = db.Users.Include(u => u.Subscribers).FirstOrDefault(u => u.Id == id).Subscribers;
            if (subscriptions.FirstOrDefault(s => s.SubscriptionUserId == id) == null)
            {
                db.Subscriptions.Add(new Subscriptions
                {
                    SubscriptionUserId = id,
                    //UserId = user.Id,
                    User = user
                });
                db.Subscribers.Add(new Subscribers
                {
                    SubUserId = user.Id,
                    User = db.Users.FirstOrDefault(u => u.Id == id),

                });
                db.SaveChanges();
            }
            return RedirectToAction("UserPage", "Account", new { id = id });
        }
        public IActionResult UnSubscribe(int? id)
        {
            IEnumerable<Subscribers> subscribers = db.Users.Include(u => u.Subscribers).FirstOrDefault(u => u.Id == id).Subscribers;
            Subscribers sub = subscribers.FirstOrDefault(s => s.SubUserId == GetInfo().Id);
            db.Subscribers.Remove(sub);
            IEnumerable<Subscriptions> subscriptions = db.Users.Include(u => u.Subscriptions).FirstOrDefault(u => u.Email == User.Identity.Name).Subscriptions;
            Subscriptions subscript = subscriptions.FirstOrDefault(s => s.SubscriptionUserId == id);
            db.Subscriptions.Remove(subscript);
            db.SaveChanges();
            return RedirectToAction("UserPage", "Account", new { id = id });
        }
        [HttpGet]
        public IActionResult ViewAllSubscriptionDish()
        {
            User curuser = GetInfo();
            IEnumerable<Subscriptions> subscriptions = db.Users.Include(u => u.Subscriptions).FirstOrDefault(u => u.Email == User.Identity.Name).Subscriptions;

            IEnumerable<Publication> pu = new List<Publication>();


            List<Publication> subPublication = new List<Publication>();
            foreach (var item in subscriptions)
            {
                List<Publication> temp = new List<Publication>();
                temp = db.Publications.Include(p => p.Photos).Include(p => p.User).Include(p => p.Category).Where(p => p.UserId == item.SubscriptionUserId).ToList();
                subPublication = subPublication.Concat(temp).ToList();
            }



            subPublication = subPublication.OrderByDescending(p => p.Time).ToList();
            return View(subPublication);
        }

        [HttpPost]
        public IActionResult AddComment(int id, string discription)
        {
            Publication publication = db.Publications.FirstOrDefault(c => c.Id == id);
            Comment comment = new Comment()
            {
                Discription = discription,
                PublicationId = publication.Id,
                UserId = GetInfo().Id
            };
            if (discription == null)
            {
                
                ModelState.AddModelError("General", "Описание должно быть заполнено");

            }
            else
            {
                db.Comments.Add(comment);
                db.SaveChanges();
               
            } 
    return RedirectToAction("Dish", publication);
        }
        public IActionResult AddCommentDishPage(int id, string discription)
        {
            Publication publication = db.Publications.FirstOrDefault(c => c.Id == id);
            Comment comment = new Comment()
            {
                Discription = discription,
                PublicationId = publication.Id,
                UserId = GetInfo().Id
            };
            db.Comments.Add(comment);
            db.SaveChanges();
            return RedirectToAction("DishPage", publication);
        }

    }
}
