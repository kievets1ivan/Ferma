namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedcost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FermaEntities", "Cost", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FermaEntities", "Cost");
        }
    }
}
