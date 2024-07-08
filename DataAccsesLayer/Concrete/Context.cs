using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsesLayer.Concrete
{
    public class Context : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MERCAN;database=FinancialTranierDb;integrated security=true;Encrypt=false");
        }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserEducationRelation> UserEducationRelations { get; set; }
        public DbSet<UserProgress> UserProgresses { get; set; }
    }
}
