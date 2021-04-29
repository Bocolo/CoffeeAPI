using CoffeeAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CoffeeAPI.Controllers
{
    public class MenuController : ApiController
    {
        CoffeeDbContext coffeeDbContext = new CoffeeDbContext();
       // [HttpGet]
        public IHttpActionResult GetMenus()
        {
            var menus = coffeeDbContext.Menus;
            return Ok(menus);
        }
     //   [HttpGet]
      /*  public IHttpActionResult Get()
        {

        }*/
    }
}
