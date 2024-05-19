namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "gender");
        }
    }
}
