using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopping.Models;

namespace Shopping.Controllers
{
    public class ProductsController : Controller
    {
        List<ProductModel> productsList = new List<ProductModel>()
            {
                new ProductModel(){id=1,name="iphone" ,price=5000f ,image="https://media.extra.com/s/aurora/100203562_800/Apple-iPhone-12-Pro-Max-5G-128GB-Pacific-Blue?locale=en-GB,ar-*,*"} ,
                new ProductModel(){id=2,name="Samsung" ,price=4300f ,image="https://images.samsung.com/is/image/samsung/p6pim/sa/galaxy-s21/gallery/sa-galaxy-s21-5g-g991-sm-g991bzvgmea-359208183"} ,
                new ProductModel(){id=3,name="Huawei" ,price=3700f ,image="https://mobizil.com/wp-content/uploads/2019/03/Huawei-P30-Pro-Black.jpg"}
            };
        public IActionResult Index(string color)
        {
            ViewData["products"] = productsList;
            ViewData["color"] = color;
            

            return View();
        }

        public IActionResult Details(int? id)
        {
            
            ProductModel product = productsList.Find(P => P.id == id);
            if (product==null)
            {
                return Content("There is no product");

            }
            else
            {
                ViewData["product"] = product;
                return View();
            }
            
        }
    }
}