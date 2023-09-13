using Lession05.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace Lession05.Controllers
{
    public class MemberController : Controller
    {
        // GET: MemberController
        public ActionResult Index()
        {
            var model = DataLocal._members.ToList();
            return View(model);
        }

        // GET: MemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MemberController/Create
        public ActionResult Create()
        {
            var member = new Member();
            return View(member);
        }

        // POST: MemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member model)
        {
            string msg = "";
            bool validate = true;
            if(model.UserName.Length<3 || model.UserName.Length > 20)
            {
                msg += "<li> Tên đăng nhập có độ dài 3-20 ký tự </li>";
            }
            string paternEmail = @"[a-z0-9._-]+@[a-z0-9.-]+\.[a-z]{2,4}";
            if (!Regex.IsMatch(model.Email, paternEmail))
            {
                msg += "<li>Email không được định dạng </li>";
                validate = false;

            }
            if(validate==true)
            {
                model.MemberId = Guid.NewGuid().ToString();
                DataLocal._members.Add(model);
                return RedirectToAction("Index");
            }
            ViewBag.error = msg;
            return View(model);
            
        }

        // GET: MemberController/Edit/5
        public ActionResult Edit(int id)
        {
            var models = DataLocal._members.ToList();
            return View(models);
        }

        // POST: MemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
