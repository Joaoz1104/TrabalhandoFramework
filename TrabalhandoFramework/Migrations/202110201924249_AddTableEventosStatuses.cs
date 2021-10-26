namespace TrabalhandoFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableEventosStatuses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Eventoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Data = c.DateTime(),
                        StatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Eventoes", "StatusId", "dbo.Status");
            DropIndex("dbo.Eventoes", new[] { "StatusId" });
            DropTable("dbo.Status");
            DropTable("dbo.Eventoes");
        }
    }
}
