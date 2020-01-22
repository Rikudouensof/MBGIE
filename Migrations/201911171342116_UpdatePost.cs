namespace MBGIE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePost : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "DateOfMakingPost", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "DateOfMakingPost", c => c.DateTime(nullable: false));
        }
    }
}
