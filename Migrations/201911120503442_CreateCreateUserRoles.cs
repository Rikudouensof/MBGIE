namespace MBGIE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCreateUserRoles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreateUserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                        ZeActualRole = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CreateUserRoles");
        }
    }
}
