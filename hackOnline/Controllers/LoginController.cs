using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.Models.Entity;
using Project.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace hackOnline.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGenericRepository<User> _userRepository;
        private readonly IGenericRepository<Category> _categoryRepository;
        private readonly IGenericRepository<Product> _productRepository;
        private readonly IGenericRepository<Image> _imageRepository;
        private readonly IGenericRepository<Comment> _commentRepository;
        private readonly IGenericRepository<UserRole> _userRoleRepository;
        private readonly IGenericRepository<Role> _rolRepository;


        public LoginController(ILogger<HomeController> logger, IGenericRepository<Category> categoryRepository,
            IGenericRepository<User> userRepository, IGenericRepository<Product> productRepository, IGenericRepository<Category> ccategoryRepository, IGenericRepository<Image> imageRepository,
            IGenericRepository<Comment> commentRepository, IGenericRepository<Role> rolRepository, IGenericRepository<UserRole> userRoleRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
            _categoryRepository = ccategoryRepository;
            _productRepository = productRepository;
            _imageRepository = imageRepository;
            _commentRepository = commentRepository;
            _rolRepository = rolRepository;
            _userRoleRepository = userRoleRepository;
        }
        public IActionResult Login()
        {
            var model = new User();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            var info = await _userRepository.Find(t => t.email == user.email && t.password == user.password);
            if (info != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.email)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Registration", "Login");
        }

        public async Task<IActionResult> Registration()
        {
            var model = new User();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Registration(User user)
        {
            user.record_time_stamp = DateTime.Now;
            await _userRepository.Insert(user);
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.email)
                };
            var useridentity = new ClaimsIdentity(claims, "Login");
            ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
            await HttpContext.SignInAsync(principal);
            return RedirectToAction("Index", "Home");
        }
    }
}
