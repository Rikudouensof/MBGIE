namespace MBGIE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Unknownafterstaletime : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ModelProfiles", "Images_Id", "dbo.Images");
            DropIndex("dbo.ModelProfiles", new[] { "Images_Id" });
            CreateTable(
                "dbo.ModelImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        ModelUsername = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ModelProfiles", "ModelImageId", c => c.Int());
            CreateIndex("dbo.ModelProfiles", "ModelImageId");
            AddForeignKey("dbo.ModelProfiles", "ModelImageId", "dbo.ModelImages", "Id");
            DropColumn("dbo.ModelProfiles", "ImageId");
            DropColumn("dbo.ModelProfiles", "Images_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ModelProfiles", "Images_Id", c => c.Int());
            AddColumn("dbo.ModelProfiles", "ImageId", c => c.Int());
            DropForeignKey("dbo.ModelProfiles", "ModelImageId", "dbo.ModelImages");
            DropIndex("dbo.ModelProfiles", new[] { "ModelImageId" });
            DropColumn("dbo.ModelProfiles", "ModelImageId");
            DropTable("dbo.ModelImages");
            CreateIndex("dbo.ModelProfiles", "Images_Id");
            AddForeignKey("dbo.ModelProfiles", "Images_Id", "dbo.Images", "Id");
        }
    }
}
