using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SMCD.Models;

namespace SMCD.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<StatusUser> StatusUsers { get; set; }
        public DbSet<Technique> Technique { get; set; }
        public DbSet<Technique> TechniqueView { get; set; }
        public DbSet<StatusTechnique> StatusTechnique { get; set; }
        public DbSet<LinkTechnique> LinkTechnique { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<LinkApplication> LinkApplications { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
