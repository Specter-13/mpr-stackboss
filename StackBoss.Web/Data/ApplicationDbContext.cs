using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StackBoss.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackBoss.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RiskEntity> RiskTable { get; set; }
    }
}
