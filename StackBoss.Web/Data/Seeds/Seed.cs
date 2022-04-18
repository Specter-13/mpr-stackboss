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
        public static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByEmailAsync("admin@admin.com").Result==null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "admin@admin.com",
                    Email = "admin@admin.com"
                };

                IdentityResult result = userManager.CreateAsync(user, "admin").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }       
        } 

         public static void SeedProjects(this ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<ProjectEntity>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.HasMany(x => x.RiskList);
                 entity.HasData(new ProjectEntity()
                {
                     Id = 1,
                     Name = "Medical IS",
                     Description = "Information system for Hospital in Brno",
                     Manager = "Ing. Jan Honza",
                     Staff = "Lukas Kudlicka, Michal Kovac",
                     CustomId = "P_001"

                });
            });
         }
        
        public static void SeedRisks(this ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<RiskEntity>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.HasOne(x => x.Project);
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
                 ProjectId = 1,
                 CustomId = "P001_R01"
                 
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
                 ProjectId = 1,
                 CustomId = "P001_R02"
                 
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
                 ProjectId = 1,
                 CustomId = "P001_R03"
                 
                });
            });
        }

       
    }
}
