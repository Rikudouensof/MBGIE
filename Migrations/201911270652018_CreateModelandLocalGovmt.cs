namespace MBGIE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateModelandLocalGovmt : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "ImagesId", "dbo.Images");
            DropIndex("dbo.Posts", new[] { "ImagesId" });
            CreateTable(
                "dbo.Localgovernments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ModelProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageId = c.Int(),
                        Weight = c.Double(nullable: false),
                        Height = c.Double(nullable: false),
                        DateofBirth = c.DateTime(nullable: false),
                        LocalgovernmentId = c.Int(nullable: false),
                        VoteCount = c.Int(nullable: false),
                        FirstName = c.String(nullable: false),
                        LatName = c.String(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Position = c.Int(nullable: false),
                        Images_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Images", t => t.Images_Id)
                .ForeignKey("dbo.Localgovernments", t => t.LocalgovernmentId, cascadeDelete: true)
                .Index(t => t.LocalgovernmentId)
                .Index(t => t.Images_Id);
            
            AlterColumn("dbo.Posts", "ImagesId", c => c.Int());
            CreateIndex("dbo.Posts", "ImagesId");
            AddForeignKey("dbo.Posts", "ImagesId", "dbo.Images", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "ImagesId", "dbo.Images");
            DropForeignKey("dbo.ModelProfiles", "LocalgovernmentId", "dbo.Localgovernments");
            DropForeignKey("dbo.ModelProfiles", "Images_Id", "dbo.Images");
            DropIndex("dbo.Posts", new[] { "ImagesId" });
            DropIndex("dbo.ModelProfiles", new[] { "Images_Id" });
            DropIndex("dbo.ModelProfiles", new[] { "LocalgovernmentId" });
            AlterColumn("dbo.Posts", "ImagesId", c => c.Int(nullable: false));
            DropTable("dbo.ModelProfiles");
            DropTable("dbo.Localgovernments");
            CreateIndex("dbo.Posts", "ImagesId");
            AddForeignKey("dbo.Posts", "ImagesId", "dbo.Images", "Id", cascadeDelete: true);
        }
    }
}
