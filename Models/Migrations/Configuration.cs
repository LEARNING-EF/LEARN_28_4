using System.Linq;

namespace Models.Migrations
{
	internal sealed class Configuration :
		System.Data.Entity.Migrations.DbMigrationsConfiguration<DatabaseContext>
	{
		public Configuration()
		{
			ContextKey = "Models.DatabaseContext";

			AutomaticMigrationsEnabled = false;
			AutomaticMigrationDataLossAllowed = false;
		}

		protected override void Seed(DatabaseContext databaseContext)
		{
			//base.Seed(databaseContext);

			if (databaseContext.People.Any())
			{
				return;
			}

			try
			{
				DatabaseContextInitializer.Seed(databaseContext);
			}
			catch
			{
			}
			//catch (System.Exception ex)
			//{
			//	Dtx.LogHandler.Report(GetType(), null, ex);
			//}
		}
	}
}
