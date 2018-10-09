using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SiteMVC.Controllers;


namespace SiteMVC.Models
{
    public class RestaurantePratoDBContext : DbContext
    {
        public DbSet<Prato> TblPrato { get; set; }
        public DbSet<Restaurante> TblRestaurante { get; set; }

    }
}