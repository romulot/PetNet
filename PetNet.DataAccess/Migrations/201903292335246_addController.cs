namespace PetNet.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addController : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProfileGroups",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Group_Id = c.Guid(),
                        Profile_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.Group_Id)
                .ForeignKey("dbo.Profiles", t => t.Profile_Id)
                .Index(t => t.Group_Id)
                .Index(t => t.Profile_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProfileGroups", "Profile_Id", "dbo.Profiles");
            DropForeignKey("dbo.ProfileGroups", "Group_Id", "dbo.Groups");
            DropIndex("dbo.ProfileGroups", new[] { "Profile_Id" });
            DropIndex("dbo.ProfileGroups", new[] { "Group_Id" });
            DropTable("dbo.ProfileGroups");
        }
    }
}
