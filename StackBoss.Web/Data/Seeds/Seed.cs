using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StackBoss.Web.Data.Entities;
using StackBoss.Web.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackBoss.Web.Data.Seeds
{
    public static class Seed
    {
        public static void SeedUsers(this ModelBuilder builder)  
        {  
            IdentityUser user = new IdentityUser()  
            {  
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",  
                UserName = "Admin",  
                Email = "admin@admin.com",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890"  
            };  
  
            PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();  
            passwordHasher.HashPassword(user, "admin123");  
  
            builder.Entity<IdentityUser>().HasData(user);  
        }  

        public static void SeedRoles(this ModelBuilder builder)  
        {  
            builder.Entity<IdentityRole>().HasData(  
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },  
                new IdentityRole() { Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = "HR", ConcurrencyStamp = "2", NormalizedName = "Human Resource" }  
                );  
        }  

        public static void SeedRisks(this ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<RiskEntity>(entity =>
            {
                entity.HasData(new RiskEntity()
                { 
                 Id = 1,
                 Name = "Risk of bankruptcy",
                 Description = "Test bussiness risk",
                 Category = Category.BusinessRisks,
                 Threat = "Loosing all of money",
                 Starters="Project wasn't finished successfuly",
                 Reaction = "Change staff, project reset",
                 Owner = "Ing. Jozko Mrkvicka",
                 Probability = Probability.Medium,
                 Consequences = Consequences.Critical,
                 RiskEvaluation = ((int)Probability.Medium) * ((int)Consequences.Critical),
                 State = State.Potential,
                 CreatedDate = new DateTime(2021,7,10),
                 ModifiedStateDate = new DateTime(2021,7,10),
                 ReactionDate = new DateTime(2022,9,20),
                 
                });
                entity.HasData(new RiskEntity()
                { 
                 Id = 2,
                 Name = "Risk of Fire",
                 Description = "Test extern risk",
                 Category = Category.ExternRisks,
                 Threat = "Loosing all of money",
                 Starters="Project wasn't finished successfuly",
                 Reaction = "Change staff, project reset",
                 Owner = "Ing. Jozko Mrkvicka",
                 Probability = Probability.Medium,
                 Consequences = Consequences.Critical,
                 RiskEvaluation = ((int)Probability.Medium) * ((int)Consequences.Critical),
                 State = State.Potential,
                 CreatedDate = new DateTime(2021,7,10),
                 ModifiedStateDate = new DateTime(2021,7,10),
                 ReactionDate = new DateTime(2022,9,20),
                 
                });
                entity.HasData(new RiskEntity()
                { 
                 Id = 3,
                 Name = "Risk of Lost Data",
                 Description = "Test bussiness risk",
                 Category = Category.BusinessRisks,
                 Threat = "Loosing all of money",
                 Starters="Project wasn't finished successfuly",
                 Reaction = "Change staff, project reset",
                 Owner = "Ing. Jozko Mrkvicka",
                 Probability = Probability.Medium,
                 Consequences = Consequences.Critical,
                 RiskEvaluation = ((int)Probability.Medium) * ((int)Consequences.Critical),
                 State = State.Potential,
                 CreatedDate = new DateTime(2021,7,10),
                 ModifiedStateDate = new DateTime(2021,7,10),
                 ReactionDate = new DateTime(2022,9,20),
                 
                });
            });
        }

       
    }
}
