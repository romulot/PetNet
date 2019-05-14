namespace PetNet.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Subject = c.String(),
                        Owner_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profiles", t => t.Owner_Id)
                .Index(t => t.Owner_Id);
            
            AddColumn("dbo.Posts", "Author_Id", c => c.Guid());
            AddColumn("dbo.Posts", "Group_Id", c => c.Guid());
            CreateIndex("dbo.Posts", "Author_Id");
            CreateIndex("dbo.Posts", "Group_Id");
            AddForeignKey("dbo.Posts", "Author_Id", "dbo.Profiles", "Id");
            AddForeignKey("dbo.Posts", "Group_Id", "dbo.Groups", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.Posts", "Author_Id", "dbo.Profiles");
            DropForeignKey("dbo.Groups", "Owner_Id", "dbo.Profiles");
            DropIndex("dbo.Posts", new[] { "Group_Id" });
            DropIndex("dbo.Posts", new[] { "Author_Id" });
            DropIndex("dbo.Groups", new[] { "Owner_Id" });
            DropColumn("dbo.Posts", "Group_Id");
            DropColumn("dbo.Posts", "Author_Id");
            DropTable("dbo.Groups");
        }
    }
}
