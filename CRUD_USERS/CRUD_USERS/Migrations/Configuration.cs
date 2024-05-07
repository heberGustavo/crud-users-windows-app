namespace CRUD_USERS.Migrations
{
	using CRUD_USERS.Models;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<CRUD_USERS.Configurations.Context.CRUDAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CRUD_USERS.Configurations.Context.CRUDAppContext context)
        {
			base.Seed(context);
		}
    }
}
