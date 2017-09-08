using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SassBootstrapExample.Models;

namespace SassBootstrapExample.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var db = new ProductContext();
            var products = db.Products.ToList();

            var vm = new Tuple<List<Product>>(products);
            
            return View(vm);
        }
    }
}