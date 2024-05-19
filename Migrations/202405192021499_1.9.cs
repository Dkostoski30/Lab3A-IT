namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _19 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "PatientCode", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "PatientCode");
        }
    }
}
