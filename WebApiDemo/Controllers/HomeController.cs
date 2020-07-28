using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApiDemo.Models;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class HomeController : ApiController
    {
        public IEnumerable<Product> GetItems()
        {
            IList<Product> products = new List<Product>
            {
                new Product
                {
                    productName = "Biscuits",
                    manufacturingYear = 2018,
                    brandName="ParleG"
                },
                new Product
                {
                    productName = "Cars",
                    manufacturingYear = 2018,
                    brandName="BMW"
                },
                new Product
                {
                    productName = "Cars",
                    manufacturingYear = 2018,
                    brandName="Mercedese"
                },
                new Product
                {
                    productName = "Brush",
                    manufacturingYear = 2017,
                    brandName="Colgate"
                }

            };

            return products;
        }
    }
}