using CoffeeAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CoffeeAPI.Data
{
    public class CoffeeDbContext :DbContext
    {
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Reservation> Reservations{ get; set; }
    }
}