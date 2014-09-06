namespace Mvc4Search.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LocalPersons",
                c => new
                    {
                        LocalPersonId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.LocalPersonId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LocalPersons");
        }
    }
}
