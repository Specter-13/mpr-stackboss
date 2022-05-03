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
        public static void SeedRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.HasData( new IdentityRole() 
                { 
                Name = "Admin", 
                NormalizedName = "Admin".ToUpper() 
                });
                entity.HasData( new IdentityRole() 
                { 
                Name = "ProjectManager", 
                NormalizedName = "ProjectManager".ToUpper() 
                });
                entity.HasData( new IdentityRole() 
                { 
                Name = "ProjectDirector", 
                NormalizedName = "ProjectDirector".ToUpper() 
                });
            });
        } 
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
                entity.HasData(new ProjectEntity()
                {
                    Id = 2,
                    Name = "Engineering IS",
                    Description = "Information system for Andrews Constructions",
                    Manager = "Ing. ´Michal Slivka",
                    Staff = "Peter Janosik, Michal Kutil",
                    CustomId = "P_002"

                });
                entity.HasData(new ProjectEntity()
                {
                    Id = 3,
                    Name = "Hotel IS",
                    Description = "Information system for Hotel Yasmin",
                    Manager = "Ing. ´Michal Chrapko",
                    Staff = "jakub Varga, Jakub Kulan",
                    CustomId = "P_003"

                });
                entity.HasData(new ProjectEntity()
                {
                    Id = 4,
                    Name = "Airport IS",
                    Description = "Information system for Kosice Airport",
                    Manager = "Ing. Ladislav Hracko",
                    Staff = "Erik Domko, Peter Krna",
                    CustomId = "P_004"

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
                 Probability = Probability.Three,
                 Consequences = Consequences.Five,
                 RiskEvaluation = ((int)Probability.Three) * ((int)Consequences.Five),
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
                 Probability = Probability.Six,
                 Consequences = Consequences.Eight,
                 RiskEvaluation = ((int)Probability.Six) * ((int)Consequences.Eight),
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
                 Probability = Probability.Four,
                 Consequences = Consequences.Ten,
                 RiskEvaluation = ((int)Probability.Four) * ((int)Consequences.Ten),
                 State = State.Potential,
                 CreatedDate = new DateTime(2021,7,10),
                 ModifiedStateDate = new DateTime(2021,7,10),
                 ReactionDate = new DateTime(2022,9,20),
                 ProjectId = 1,
                 CustomId = "P001_R03"
                 
                });
                entity.HasData(new RiskEntity()
                {
                Id = 4,
                Name = "Risk of Hacking",
                Description = "Test technical risk",
                Category = Category.TechnicalRisks,
                Threat = "Loosing all of money",
                Starters = "Project wasn't secure enough",
                Reaction = "Increase security",
                Owner = "Ing. Jan Hrasko",
                Probability = Probability.Five,
                Consequences = Consequences.Five,
                RiskEvaluation = ((int)Probability.Five) * ((int)Consequences.Five),
                State = State.Potential,
                CreatedDate = new DateTime(2021, 10, 21),
                ModifiedStateDate = new DateTime(2021, 10, 23),
                ReactionDate = new DateTime(2022, 8, 5),
                ProjectId = 2,
                CustomId = "P002_R01"

                });
                entity.HasData(new RiskEntity()
                {
                    Id = 5,
                    Name = "Risk of Planning",
                    Description = "Test project risk",
                    Category = Category.ProjectRisks,
                    Threat = "Loss of control of the project",
                    Starters = "Insufficient control of employees",
                    Reaction = "Increase employee control",
                    Owner = "Ing. Jan Hrasko",
                    Probability = Probability.Two,
                    Consequences = Consequences.Seven,
                    RiskEvaluation = ((int)Probability.Two) * ((int)Consequences.Seven),
                    State = State.Occured,
                    CreatedDate = new DateTime(2021, 10, 21),
                    ModifiedStateDate = new DateTime(2021, 10, 23),
                    ReactionDate = new DateTime(2022, 8, 5),
                    ProjectId = 2,
                    CustomId = "P002_R02"

                });

            });
        }

       
    }
}
