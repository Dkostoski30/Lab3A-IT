namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _16 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Doctors", "HospitalID", "dbo.Hospitals");
            DropIndex("dbo.Doctors", new[] { "HospitalID" });
            RenameColumn(table: "dbo.Doctors", name: "HospitalID", newName: "Hospital_ID");
            AlterColumn("dbo.Doctors", "Hospital_ID", c => c.Int());
            CreateIndex("dbo.Doctors", "Hospital_ID");
            AddForeignKey("dbo.Doctors", "Hospital_ID", "dbo.Hospitals", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doctors", "Hospital_ID", "dbo.Hospitals");
            DropIndex("dbo.Doctors", new[] { "Hospital_ID" });
            AlterColumn("dbo.Doctors", "Hospital_ID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Doctors", name: "Hospital_ID", newName: "HospitalID");
            CreateIndex("dbo.Doctors", "HospitalID");
            AddForeignKey("dbo.Doctors", "HospitalID", "dbo.Hospitals", "ID", cascadeDelete: true);
        }
    }
}
