namespace Models.Migrations
{
	using System;
	using System.Data.Entity.Migrations;

	public partial class Version002 : DbMigration
	{
		public override void Up()
		{
			//AddColumn("dbo.People", "SomeNewProperty", c => c.String());
			//DropColumn("dbo.People", "SomeProperty");

			// این ویژگی متاسفانه در
			// Sql Server Compact Edtion (CE)
			// کار نمی‌کند
			RenameColumn("dbo.People", "SomeProperty", "SomeNewProperty");
		}

		public override void Down()
		{
			//AddColumn("dbo.People", "SomeProperty", c => c.String());
			//DropColumn("dbo.People", "SomeNewProperty");

			RenameColumn("dbo.People", "SomeNewProperty", "SomeProperty");
		}
	}
}
