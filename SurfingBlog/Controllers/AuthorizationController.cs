using SurfingBlog.DAL;
using SurfingBlog.Helpers;
using SurfingBlog.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SurfingBlog.Controllers
{
    public class AuthorizationController : Controller
    {
        SurfDbContext dbContext = new SurfDbContext();

        // GET: Authorization
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(
                    c => c.Nickname == model.Nickname
                    && c.Password == model.Password);

                if (userInDb != null)
                {
                    FormsAuthentication.SetAuthCookie(userInDb.Nickname, model.Remember);
                    Session["UserId"] = userInDb.Id.ToString();
                    Session["Nickname"] = userInDb.Nickname;
                    Session["Photo"] = ImageUrlHelper.GetUrl(userInDb.Photo);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Неверный псевдоним или пароль");
                }
            }
            return View("Index", model);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            Request.Cookies.Clear();
            return RedirectToAction("Index");
        }
    }
}