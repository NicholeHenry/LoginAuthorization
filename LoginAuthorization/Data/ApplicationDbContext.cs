using System;
using System.Collections.Generic;
using System.Text;
using LoginAuthorization.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoginAuthorization.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Test> Test { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
