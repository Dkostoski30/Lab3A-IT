namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _17 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "Age", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Doctors", "Age");
        }
    }
}
