using App.Business.Services;
using App.Data;
using App.Data.Entity;
using App.Web.Mvc.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
//using Umbraco.Core.Models.Membership;
//using Umbraco.Core.Services.Implement;

namespace App.Web.Mvc.Controllers
{
    public class AuthController : Controller
    {
        private readonly AppDbContext _context;
        private readonly EmailService _emailService;
        private readonly UserService _userService;


        public AuthController(AppDbContext context, EmailService emailService, UserService userService)
        {
            _context = context;
            _emailService = emailService;
            _userService = userService;
           // _userService = userService;

        }
        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userDb = _context.Users.FirstOrDefault(e => e.Email == model.EmailAddress);
                if (userDb != null)
                {
                    ModelState.AddModelError("EmailAddress", "Email exists!");
                    return View(model);
                }

                var newUser = new App.Data.Entity.User()
                {
                    Email = model.EmailAddress,
                    Password = model.Password,
                    City = model.City,
                    Name = model.Name,
                    Phone = model.Phone

                };
                _context.Users.Add(newUser);
                _context.SaveChanges();


                return RedirectToAction(nameof(Login));
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult Login() => View();
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Users.FirstOrDefault(e =>
                e.Email == model.EmailAddress &&
                e.Password == model.Password);


                if (user != null)
                {
                    var claims = new List<Claim>
                {
                    new Claim("Id",Convert.ToString(user.Id)),
                    new Claim(ClaimTypes.Name, user.Name ?? ""),
                    new Claim(ClaimTypes.Email, model.EmailAddress),
                     new Claim("Password",user.Password),
                    new Claim("City", user.City ?? ""),
                     new Claim(ClaimTypes.MobilePhone, user.Phone)
                };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal(identity);

                    var props = new AuthenticationProperties()
                    {
                        IsPersistent = model.RememberMe,
                        ExpiresUtc = DateTime.UtcNow.AddMinutes(15),
                    };

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        principal,
                        props
                    );

                    return Redirect("/");
                }
                else
                {
                    ViewBag.Error = "E-Mail veya şifre yanlış";
                }

            }
            
            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return Redirect("/");
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ForgotPassword(string email , string password )
        {
            var user = _context.Users.FirstOrDefault(e =>
                e.Email == email &&
                e.Password == password);

            if (user != null)
            {
                string resetToken = user.Email;
                string resetLink = Url.Action("ResetPassword", "Auth", new { token = resetToken }, Request.Scheme);


                _emailService.Send(email, resetLink,user.Name); ViewBag.Message = "A password reset link has been sent to your email address.";
            }
            else
            {
                ModelState.AddModelError("", "Invalid email address");
            }

            return View();
        }

        public IActionResult ResetPassword(string email)
        {
          
                return View();
           
        }

        [HttpPost]
        public IActionResult ResetPassword(string email, string newPassword)
        {
            var user = _context.Users.FirstOrDefault(e =>
                e.Email == email &&
                e.Password == newPassword);

            if (user != null)
            {
                ViewBag.Message = "Password reset successful.";
            }

            else
            {
                return RedirectToAction("ForgotPassword");
            }

            return View();
        }
    }
}

