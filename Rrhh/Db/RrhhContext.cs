﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Rrhh.Db;
using Rrhh.Models;

namespace Rrhh.Migrations
{
    public class RrhhContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<BasicCompetence> Competences { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new BasicCompetenceConfiguration());
            modelBuilder.Configurations.Add(new AcademicCompetenceConfiguration());
            modelBuilder.Configurations.Add(new CandidateConfiguration());
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
            modelBuilder.Configurations.Add(new LanguageConfiguration());
            modelBuilder.Configurations.Add(new ResumeConfiguration());
            modelBuilder.Configurations.Add(new JobOfferConfiguration());

        }
        public override int SaveChanges()
        {
            var context = ((IObjectContextAdapter)this).ObjectContext;

            var objectStateEntries =
                from e in context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified)
                where
                    e.IsRelationship == false && e.Entity is BaseModel
                select e;

            var currentTime = DateTime.Now;

            foreach (var entry in objectStateEntries)
            {
                var entityBase = entry.Entity as BaseModel;

                if (entry.State == EntityState.Added && entityBase != null)
                {
                    entityBase.CreatedDate = currentTime;
                    entityBase.IsActive = true;
                }

                if (entityBase != null) entityBase.LastModifiedDate = currentTime;
            }

            return base.SaveChanges();
        }
    }
}
