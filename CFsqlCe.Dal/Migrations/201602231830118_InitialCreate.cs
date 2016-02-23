namespace CFSqlCe.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Surname = c.String(maxLength: 50),
                        Note = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ActorRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActorId = c.Int(nullable: false),
                        Character = c.String(maxLength: 50),
                        Description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Actors", t => t.ActorId, cascadeDelete: true)
                .Index(t => t.ActorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ActorRoles", "ActorId", "dbo.Actors");
            DropIndex("dbo.ActorRoles", new[] { "ActorId" });
            DropTable("dbo.ActorRoles");
            DropTable("dbo.Actors");
        }
    }
}
