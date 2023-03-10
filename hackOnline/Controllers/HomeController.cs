using hackOnline.Models;
using hackOnline.Models.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proje.Models;
using Project.Models.Entity;
using Project.Models.Services;
using Project.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace hackOnline.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGenericRepository<User> _userRepository;
        private readonly IGenericRepository<Category> _categoryRepository;
        private readonly IGenericRepository<Product> _productRepository;
        private readonly IGenericRepository<Image> _imageRepository;
        private readonly IGenericRepository<Comment> _commentRepository;
        private readonly IGenericRepository<UserRole> _userRoleRepository;
        private readonly IGenericRepository<Role> _rolRepository;
        private readonly IGenericRepository<Cart> _cartRepository;
        private readonly IGenericRepository<Favorites> _favoritesRepository;
        private readonly IGenericRepository<Zakaz> _zakazRepository;
        private IHostingEnvironment Environment;

        public HomeController(ILogger<HomeController> logger,IGenericRepository<Category> categoryRepository, IGenericRepository<Cart> cartRepository,
            IGenericRepository<User> userRepository, IGenericRepository<Product> productRepository, IGenericRepository<Category> ccategoryRepository, IGenericRepository<Image> imageRepository,
            IGenericRepository<Comment> commentRepository, IGenericRepository<Role> rolRepository, IGenericRepository<UserRole> userRoleRepository, IHostingEnvironment _environment,
            IGenericRepository<Favorites> favoritesRepository, IGenericRepository<Zakaz> zakazRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
            _categoryRepository = ccategoryRepository;
            _productRepository = productRepository;
            _imageRepository = imageRepository;
            _commentRepository = commentRepository;
            _rolRepository = rolRepository;
            _userRoleRepository = userRoleRepository;
            Environment = _environment;
            _cartRepository = cartRepository;
            _favoritesRepository = favoritesRepository;
            _zakazRepository = zakazRepository;
        }

        
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> GetCategory()
        {
            var model = new GetAllProductsViewModel();
            model.Categories = await _categoryRepository.GetAll();
            model.Products = await _productRepository.GetAll();
            for(int i = 0; i < model.Products.Count; i++)
            {
                var image = await _imageRepository.Find(t => t.product_id == model.Products[i].id);
                if (image != null)
                {
                    var pi = new ProductImage()
                    {
                        id = model.Products[i].id,
                        name = model.Products[i].name,
                        description = model.Products[i].description,
                        price = model.Products[i].price,
                        stock = model.Products[i].stock,
                        available = model.Products[i].available,
                        created = model.Products[i].created,
                        category = model.Products[i].category,
                        file_name = image.file_name,
                        isImage = true,
                    };
                    model.ProductImages.Add(pi);
                }
                else
                {
                    var pi = new ProductImage()
                    {
                        id = model.Products[i].id,
                        name = model.Products[i].name,
                        description = model.Products[i].description,
                        price = model.Products[i].price,
                        stock = model.Products[i].stock,
                        available = model.Products[i].available,
                        created = model.Products[i].created,
                        category = model.Products[i].category,
                        file_name = "",
                        isImage = false,
                    };
                    model.ProductImages.Add(pi);
                }
            }
            var ids = User.Identity.Name;
            if (ids != null)
            {
                ApplicationContext c = new ApplicationContext();
                var userId = c.users.Where(x => x.email == ids).Select(y => y.id).FirstOrDefault();
                model.userId = userId;
                var rol = await _userRoleRepository.Find(t => t.user_id == userId);
                if (rol != null)
                {
                    var role = await _rolRepository.SelectOne(rol.role_id);
                    model.role = role.name;
                }
                else
                {
                    model.role = "";
                }
            }
            else
            {
                model.role = "";

            }
            return View(model);
        }

        public async Task<IActionResult> GetProducts(int id)
        {
            var model = new GetAllProductsViewModel();
            model.Products = await _productRepository.FindAll(t => t.category == id);
            var ids = User.Identity.Name;
            if (ids != null)
            {
                ApplicationContext c = new ApplicationContext();
                var userId = c.users.Where(x => x.email == ids).Select(y => y.id).FirstOrDefault();
                model.userId = userId;
                var rol = await _userRoleRepository.Find(t => t.user_id == userId);
                if (rol != null)
                {
                    var role = await _rolRepository.SelectOne(rol.role_id);
                    model.role = role.name;
                }
                else
                {
                    model.role = "";
                }
            }
            else
            {
                model.role = "";
            }
            
            return View(model);
        }


        public async Task<IActionResult> Product(int id)
        {
            var model = new GetAllProductsViewModel();
            model.productId = id;
            model.GetProduct = await _productRepository.SelectOne(id);
            var comments = await _commentRepository.FindAll(t => t.product_id == id);
            for (int i = 0; i < comments.Count; i++)
            {
                var user = await _userRepository.SelectOne(comments[i].user_id);
                var comment = new CommentProduct()
                {
                    id = comments[i].id,
                    description = comments[i].description, 
                    username = user.name+" "+user.surname,
                    product_id = comments[i].product_id,
                    record_time_stamp = comments[i].record_time_stamp,
                };
                model.CommentProducts.Add(comment);
                
            }
            var ids = User.Identity.Name;
            if (ids != null)
            {
                ApplicationContext c = new ApplicationContext();
                var userId = c.users.Where(x => x.email == ids).Select(y => y.id).FirstOrDefault();
                model.userId = userId;
                var rol = await _userRoleRepository.Find(t => t.user_id == userId);
                if(rol != null)
                {
                    var role = await _rolRepository.SelectOne(rol.role_id);
                    model.role = role.name;
                }
                else
                {
                    model.role = "";
                }
            }
            return View(model);
        }

        public async Task<IActionResult> saveComment(int id,int prId, string text)
        {
            var com = new Comment();
            com.user_id = id;
            com.description = text;
            com.product_id = prId;
            com.record_time_stamp = DateTime.Now;

            await _commentRepository.Insert(com);
            var model = new GetAllProductsViewModel();
            var comments = await _commentRepository.FindAll(t => t.product_id == prId);
            for (int i = 0; i < comments.Count; i++)
            {
                var user = await _userRepository.SelectOne(comments[i].user_id);
                var comment = new CommentProduct()
                {
                    id = comments[i].id,
                    description = comments[i].description,
                    username = user.name + " " + user.surname,
                    product_id = comments[i].product_id,
                    record_time_stamp = comments[i].record_time_stamp,
                };
                model.CommentProducts.Add(comment);

            }

            var ids = User.Identity.Name;
            if (ids != null)
            {
                ApplicationContext c = new ApplicationContext();
                var userId = c.users.Where(x => x.email == ids).Select(y => y.id).FirstOrDefault();
                model.userId = userId;
                var rol = await _userRoleRepository.Find(t => t.user_id == userId);
                if (rol != null)
                {
                    var role = await _rolRepository.SelectOne(rol.role_id);
                    model.role = role.name;
                }
                else
                {
                    model.role = "";
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<JsonResult> DeleteComment(int id)
        {
            var comment = await _commentRepository.SelectOne(id);
            await _commentRepository.Delete(comment);
            return Json(true);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var model = new EditProductViewModel();
            model.Categories = await _categoryRepository.GetAll();
            var product = await _productRepository.SelectOne(id);
            model.Product = product;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditProductViewModel model)
        {
            var pr = new Product();
            pr.id = model.Product.id;
            pr.name = model.Product.name;
            pr.description = model.Product.description;
            pr.category = model.Product.category;
            pr.created = DateTime.Now;
            pr.price = model.Product.price;
            pr.stock = model.Product.stock;
            pr.available = model.Product.available;

            await _productRepository.Update(pr);
            return RedirectToAction("GetCategory");

        }

        [HttpPost]
        public async Task<JsonResult> DeleteProduct(int id)
        {
            var product = await _productRepository.SelectOne(id);
            await _productRepository.Delete(product);
            return Json(true);
        }

        public async Task<ActionResult> AddProduct(int id, Product product)
        {
            var model = new AddProductViewModel();
            model.Categories = await _categoryRepository.GetAll();


            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct(AddProductViewModel model)
        {
            model.Product.available = true;
            model.Product.created = DateTime.Now;
            var p = await _productRepository.Insert(model.Product);
            if (model.Photo.Count > 0)
            {

                string wwwPath = this.Environment.WebRootPath;
                string contentPath = this.Environment.ContentRootPath;

                string path = Path.Combine(this.Environment.WebRootPath, "Uploads");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                List<string> uploadedFiles = new List<string>();
                foreach (var postedFile in model.Photo)
                {
                    string fileName = Path.GetFileName(postedFile.FileName);
                    using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                    {
                        postedFile.CopyTo(stream);
                        uploadedFiles.Add(fileName);
                    }

                    var d = new Image()
                    {
                        product_id = p.id,
                        file_name = postedFile.FileName,
                        file_path = path,
                        file_type = postedFile.ContentType,
                        record_time_stamp = DateTime.Now,

                    };
                    await _imageRepository.Insert(d);
                }

            }
            return RedirectToAction("GetCategory");
        }

        public async Task<IActionResult> Cart(int id)
        {
            int userId = 0;
            if (id > 0)
            {
                
                var ids = User.Identity.Name;
                if (ids != null)
                {
                    ApplicationContext c = new ApplicationContext();
                    userId = c.users.Where(x => x.email == ids).Select(y => y.id).FirstOrDefault();

                }

                var cc = await _cartRepository.FindAll(t => t.UserId == userId && t.ProductId == id);
                if(cc.Count == 0)
                {
                    var cart = new Cart()
                    {
                        UserId = userId,
                        ProductId = id,
                        RecordTimeStamp = DateTime.Now,
                    };

                    await _cartRepository.Insert(cart);
                }
                
                var model = new CartProductViewModel();
                var carts = await _cartRepository.FindAll(t => t.UserId == userId);
                for (int i = 0; i < carts.Count; i++)
                {
                    var product = await _productRepository.SelectOne(id);
                    model.Products.Add(product);
                }
                model.userId = userId;
                return View(model);
            }
            else
            {
                var ids = User.Identity.Name;
                if (ids != null)
                {
                    ApplicationContext c = new ApplicationContext();
                    userId = c.users.Where(x => x.email == ids).Select(y => y.id).FirstOrDefault();

                }
                var model = new CartProductViewModel();
                var carts = await _cartRepository.FindAll(t => t.UserId == userId);
                for (int i = 0; i < carts.Count; i++)
                {
                    var product = await _productRepository.SelectOne(id);
                    if(product != null)
                    {
                        model.Products.Add(product);
                    }
                    
                }
                model.userId = userId;
                return View(model);
            }
            
        }

        public async Task<JsonResult> DeleteCartProduct(int id, int userId)
        {
            var cart = await _cartRepository.Find(t => t.ProductId == id && t.UserId == userId);
            await _cartRepository.Delete(cart);

            return Json(true);
        }

        public async Task<IActionResult> AddCategory()
        {
            var category = new Category();
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> AddCatecory(Category category)
        {
            await _categoryRepository.Insert(category);
            return RedirectToAction("GetCategory");
        }

        [HttpPost]
        public async Task<JsonResult> DeleteCategory(int id)
        {
            var category = await _categoryRepository.SelectOne(id);
            await _categoryRepository.Delete(category);
            return Json(true);
        }

        [HttpPost]
        public async Task<JsonResult> DeleteFavoritesProduct(int id, int userId)
        {
            var favorite = await _favoritesRepository.Find(t => t.productId == id && t.userId == userId);
            await _favoritesRepository.Delete(favorite);
            return Json(true);
        }

        public async Task<IActionResult> About()
        {
            return View();
        }

        public async Task<IActionResult> Favorites(int id)
        {
            int userId = 0;
            if (id > 0)
            {

                var ids = User.Identity.Name;
                if (ids != null)
                {
                    ApplicationContext c = new ApplicationContext();
                    userId = c.users.Where(x => x.email == ids).Select(y => y.id).FirstOrDefault();

                }

                var fav = await _favoritesRepository.FindAll(t => t.userId == userId && t.productId == id);
                if(fav.Count == 0)
                {
                    var favorites = new Favorites()
                    {
                        userId = userId,
                        productId = id,
                        RecordTimeStamp = DateTime.Now,
                    };

                    await _favoritesRepository.Insert(favorites);
                }
               
                var model = new CartProductViewModel();
                var favoritess = await _favoritesRepository.FindAll(t => t.userId == userId);
                for (int i = 0; i < favoritess.Count; i++)
                {
                    var product = await _productRepository.SelectOne(id);
                    model.Products.Add(product);
                }
                model.userId = userId;
                return View(model);
            }
            else
            {
                var ids = User.Identity.Name;
                if (ids != null)
                {
                    ApplicationContext c = new ApplicationContext();
                    userId = c.users.Where(x => x.email == ids).Select(y => y.id).FirstOrDefault();

                }
                var model = new CartProductViewModel();
                var favoritess = await _favoritesRepository.FindAll(t => t.userId == userId);
                for (int i = 0; i < favoritess.Count; i++)
                {
                    var product = await _productRepository.SelectOne(id);
                    if (product != null)
                    {
                        model.Products.Add(product);
                    }

                }
                model.userId = userId;
                return View(model);
            }
        }

        public async Task<IActionResult> SaveZakazProduct(int id, int userId)
        {
            var cards = await _cartRepository.FindAll(t => t.ProductId == id && t.UserId == userId);
            for(int i = 0; i < cards.Count; i++)
            {
                await _cartRepository.Delete(cards[i]);
            }

            var z = new Zakaz()
            {
                UserId = userId,
                ProductId = id,
                RecordTimeStamp = DateTime.Now
            };
        
            await _zakazRepository.Insert(z);

            return Json(true);
        }

        public async Task<IActionResult> Zakaz()
        {
            int userId = 0;
            var ids = User.Identity.Name;
                if (ids != null)
                {
                    ApplicationContext c = new ApplicationContext();
                    userId = c.users.Where(x => x.email == ids).Select(y => y.id).FirstOrDefault();

                }

            var model = new CartProductViewModel();
            var zakaz = await _zakazRepository.FindAll(t => t.UserId == userId);
            for(int i = 0; i < zakaz.Count; i++)
            {
                var product = await _productRepository.SelectOne(zakaz[i].ProductId);
                model.Products.Add(product);
            }
            model.userId = userId;
            return View(model);
        }

        [HttpPost]
        public async Task<JsonResult> DeleteZakazProduct(int id, int userId)
        {
            var zakazs = await _zakazRepository.FindAll(t => t.ProductId == id && t.UserId == userId);
            if(zakazs.Count > 0)
            {
                for(int i = 0; i < zakazs.Count(); i++)
                {
                    await _zakazRepository.Delete(zakazs[i]);
                }
            }

            return Json(true);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
