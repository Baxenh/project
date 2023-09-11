using Lession04.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace Lession04.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            // tạo đối tượng sử dụng Model member
            var member = new Member();
            // gan cá thông tin cho đôi tượng
            member.MemberId = Guid.NewGuid().ToString();
            member.UserName = "VaBaXenh";
            member.FullName = "Va Bá Xênh";
            member.Password = "12345";
            member.Email = "xenhit2019@gmail.com";
            // truyền view qua đối tượng ViewBag
           // ViewBag.Member = member;
            return View(member);
        }
        public IActionResult GetMembers()
        {
            List<Member> members = new List<Member>()
            {
                new Member { MemberId = Guid.NewGuid().ToString(), UserName = "VaBaXenh", FullName = "Va Bá Xênh", Password = "12345", Email = "xenhit2019@gmail.com" },
                new Member { MemberId = Guid.NewGuid().ToString(), UserName = "VaBaXenh2", FullName = "Va Bá Xênh", Password = "12345", Email = "xenhit2019@gmail.com" },
                new Member { MemberId = Guid.NewGuid().ToString(), UserName = "VaBaXenh", FullName = "Va Bá Xênh", Password = "12345", Email = "xenhit2019@gmail.com" },
                new Member { MemberId = Guid.NewGuid().ToString(), UserName = "VaBaXenh3", FullName = "Va Bá Xênh", Password = "12345", Email = "xenhit2019@gmail.com" },
                new Member { MemberId = Guid.NewGuid().ToString(), UserName = "VaBaXenh4", FullName = "Va Bá Xênh", Password = "12345", Email = "xenhit2019@gmail.com" },
                new Member { MemberId = Guid.NewGuid().ToString(), UserName = "VaBaXenh5", FullName = "Va Bá Xênh", Password = "12345", Email = "xenhit2019@gmail.com" },
                new Member { MemberId = Guid.NewGuid().ToString(), UserName = "VaBaXenh6", FullName = "Va Bá Xênh", Password = "12345", Email = "xenhit2019@gmail.com" },
            };           
            // truyền view qua đối tượng ViewBag
            ViewBag.Member = members;
            return View();
        }
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
        public IActionResult ListMember()
        {
            //ViewBag.Members = members;
            return View(members);
        }
        public IActionResult GetMember()
        {
            ViewBag.Members = members;
            return View();
        }
        //Default là Get
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]//hành động ứng với method là post
        public IActionResult Create (Member member)
        {
            member.MemberId = Guid.NewGuid().ToString();
            members.Add(member);
            return RedirectToAction("ListMember");
        }
    }
}
