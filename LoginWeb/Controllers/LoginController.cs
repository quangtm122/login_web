using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginWeb.Models;
using LoginWeb.ViewModel;

namespace LoginWeb.Controllers
{
    public class LoginController : Controller
    {

        IAccountModel _accountModel;
        public IAccountModel accountModel { get { return _accountModel ?? (_accountModel = new AccountModel()); } private set { } }
        public ActionResult Index()
        {
            LoginViewModel md = new LoginViewModel(); 
            return View(md);
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel obj)
        {
            if (ModelState.IsValid)
            {
                var res = accountModel.CheckLogin(obj.userName, obj.passWord);

                if (res != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Error", "Tài khoản hoặc mật khẩu không đúng");
                }

            }
        /*    if (obj.userName=="Admin" && obj.passWord=="1")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("Error", "Tài khoản hoặc mật khẩu không đúng");
            }
*/
            return View("Index");
        }

    } 
}