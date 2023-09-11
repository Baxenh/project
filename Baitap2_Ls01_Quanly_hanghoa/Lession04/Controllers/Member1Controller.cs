using Lession04.Models.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lession04.Controllers
{
    public class Member1Controller : Controller
    {
        private static readonly List<Member> members = new List<Member>()
            {
                new Member { MemberId = Guid.NewGuid().ToString(), UserName = "VaBaXenh", FullName = "Va Bá Xênh", Password = "12345", Email = "xenhit2019@gmail.com" },
                new Member { MemberId = Guid.NewGuid().ToString(), UserName = "VaBaXenh2", FullName = "Va Bá Xênh", Password = "12345", Email = "xenhit2019@gmail.com" },
                new Member { MemberId = Guid.NewGuid().ToString(), UserName = "VaBaXenh", FullName = "Va Bá Xênh", Password = "12345", Email = "xenhit2019@gmail.com" },
                new Member { MemberId = Guid.NewGuid().ToString(), UserName = "VaBaXenh3", FullName = "Va Bá Xênh", Password = "12345", Email = "xenhit2019@gmail.com" },
                new Member { MemberId = Guid.NewGuid().ToString(), UserName = "VaBaXenh4", FullName = "Va Bá Xênh", Password = "12345", Email = "xenhit2019@gmail.com" },
                new Member { MemberId = Guid.NewGuid().ToString(), UserName = "VaBaXenh5", FullName = "Va Bá Xênh", Password = "12345", Email = "xenhit2019@gmail.com" },
                new Member { MemberId = Guid.NewGuid().ToString(), UserName = "VaBaXenh6", FullName = "Va Bá Xênh", Password = "12345", Email = "xenhit2019@gmail.com" },
            };

        // GET: Member1Controller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Member1Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Member1Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Member1Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            try
            {
                member.MemberId = Guid.NewGuid().ToString();
                members.Add(member);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Member1Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Member1Controller/Edit/5
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

        // GET: Member1Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Member1Controller/Delete/5
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
