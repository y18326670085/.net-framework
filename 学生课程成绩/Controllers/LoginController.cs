using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using 学生课程成绩.Models;

namespace 学生课程成绩.Controllers
{
    public class LoginController : Controller
    {
        protected readonly LocalContext _context;
        public LoginController(LocalContext context)
        {
            _context = context;
        }
        

        [AllowAnonymous]
        public IActionResult Index()
        {
            //获取当前所有用户信息，便于测试
            //
            //### ViewBag.stuList = _context.Student_DB.Include(x=>x.department).ToList();
            //### ViewBag.claList = _context.Class_DB.ToList();
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        ///<summary>
        ///username password 来自用户输入
        ///</summary>
        public async Task<IActionResult> Checkuser(string username,string password,string returnUrl)
        {
            var user = _context.Student_DB.SingleOrDefault(s => s.UserName == username && s.Password == password);
            if (user != null)
            {
                List<ClaimsIdentity> ci = new List<ClaimsIdentity>();
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Sid, username));
                identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));
                identity.AddClaim(new Claim(ClaimTypes.Role, user.Position));
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));
                
                return RedirectToAction(nameof(MainController.Index), "Main");
            }
            else
            {
                const string badUserNameOrPasswordMessage = "用户名或密码错误！";
                return BadRequest(badUserNameOrPasswordMessage);


            }
            
        }


        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }


        [AllowAnonymous]
        public IActionResult Denied() {
            return View();
        }

        
    }
}