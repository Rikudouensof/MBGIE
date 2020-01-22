namespace MBGIE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePost : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Content = c.String(nullable: false),
                        DateOfMakingPost = c.DateTime(nullable: false),
                        CategoriesId = c.Int(nullable: false),
                        ImagesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoriesId, cascadeDelete: true)
                .ForeignKey("dbo.Images", t => t.ImagesId, cascadeDelete: true)
                .Index(t => t.CategoriesId)
                .Index(t => t.ImagesId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "ImagesId", "dbo.Images");
            DropForeignKey("dbo.Posts", "CategoriesId", "dbo.Categories");
            DropIndex("dbo.Posts", new[] { "ImagesId" });
            DropIndex("dbo.Posts", new[] { "CategoriesId" });
            DropTable("dbo.Posts");
        }
    }
}
