using System;
using System.Collections.Generic;
using System.Text;
using HotelMVC2019.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelMVC2019.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<HotelMVC> HotelMvcs { get; set; }
        public DbSet<RoomMVC> RoomMvcs { get; set; }
    }
}
