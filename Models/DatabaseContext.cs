﻿namespace Models
{
	public class DatabaseContext : System.Data.Entity.DbContext
	{
		static DatabaseContext()
		{
			//System.Data.Entity.Database.SetInitializer
			//	(new DatabaseContextInitializerBeforeTheFirstRelease());

			System.Data.Entity.Database.SetInitializer
				(new System.Data.Entity.MigrateDatabaseToLatestVersion
					<DatabaseContext, Migrations.Configuration>());
		}

		public DatabaseContext() : base()
		{
		}

		// **********
		public System.Data.Entity.DbSet<Person> People { get; set; }
		// **********

		protected override void OnModelCreating
			(System.Data.Entity.DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
