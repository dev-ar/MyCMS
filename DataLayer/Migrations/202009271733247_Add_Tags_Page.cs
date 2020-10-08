namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Tags_Page : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pages", "Tags", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pages", "Tags");
        }
    }
}
