using GTR_Assignment.EF.Model;
using GTR_Assignment.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;
using System.Security.Principal;

namespace GTR_Assignment.EF
{
    public class GtrContext: DbContext
    {
        public GtrContext(DbContextOptions<GtrContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
