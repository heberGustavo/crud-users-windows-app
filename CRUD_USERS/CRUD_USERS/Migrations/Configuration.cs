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
			IList<User> defaultUsers = new List<User>();

			defaultUsers.Add(new User { FirstName = "Heber", LastName = "Gustavo", Age = 25, Address = "Brazil/SP - Santa Barbara D Oeste", Birthday = Convert.ToDateTime("1998-04-30") });
			defaultUsers.Add(new User { FirstName = "Priscila", LastName = "Marques", Age = 21, Address = "Brazil/SP - Santa Barbara D Oeste", Birthday = Convert.ToDateTime("2022-11-13") });
			defaultUsers.Add(new User { FirstName = "Ravi", LastName = "Cruz", Age = 1, Address = "Brazil/SP - Santa Barbara D Oeste", Birthday = Convert.ToDateTime("2027-04-01") });

			context.Users.AddRange(defaultUsers);

			base.Seed(context);
		}
    }
}
