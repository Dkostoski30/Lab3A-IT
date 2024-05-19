namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _13 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Doctors", "Hospital_ID", "dbo.Hospitals");
            DropIndex("dbo.Doctors", new[] { "Hospital_ID" });
            RenameColumn(table: "dbo.Doctors", name: "Hospital_ID", newName: "HospitalID");
            AlterColumn("dbo.Doctors", "HospitalID", c => c.Int(nullable: false));
            CreateIndex("dbo.Doctors", "HospitalID");
            AddForeignKey("dbo.Doctors", "HospitalID", "dbo.Hospitals", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doctors", "HospitalID", "dbo.Hospitals");
            DropIndex("dbo.Doctors", new[] { "HospitalID" });
            AlterColumn("dbo.Doctors", "HospitalID", c => c.Int());
            RenameColumn(table: "dbo.Doctors", name: "HospitalID", newName: "Hospital_ID");
            CreateIndex("dbo.Doctors", "Hospital_ID");
            AddForeignKey("dbo.Doctors", "Hospital_ID", "dbo.Hospitals", "ID");
        }
    }
}
