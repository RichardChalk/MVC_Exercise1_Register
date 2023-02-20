using Microsoft.AspNetCore.Mvc;
using Register.ViewModels;

namespace Register.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(CreateUserViewModel userVM)
        {
            if (ModelState.IsValid)
            {
                var user = new User();
                user.Email = userVM.Email;
                user.Password = userVM.Password;
                user.FirstName = userVM.FirstName;
                user.LastName = userVM.LastName;

                // This is where we can save to the database (if we had one!)
                // _context.SaveChanges();

                return RedirectToAction("RegisterConfirmation");
            }

            return RedirectToAction("Create");
        }

        public IActionResult RegisterConfirmation()
        {
            return View();
        }
    }
}
