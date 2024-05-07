using CRUD_USERS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_USERS.Configurations.Context
{
	public class CRUDAppContext : DbContext
	{
        public CRUDAppContext() : base("MyDBConnectionString") { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
