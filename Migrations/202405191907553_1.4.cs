namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _14 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hospitals", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Doctors", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Hospitals", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Hospitals", "image_url", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Hospitals", "image_url", c => c.String());
            AlterColumn("dbo.Hospitals", "Name", c => c.String());
            AlterColumn("dbo.Doctors", "Name", c => c.String());
            DropColumn("dbo.Hospitals", "Address");
        }
    }
}
