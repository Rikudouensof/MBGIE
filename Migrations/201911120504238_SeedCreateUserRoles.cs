namespace MBGIE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedCreateUserRoles : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CreateUserRoles(RoleName, ZeActualRole)Values('Model', 'KWaViehwZeModels')");
            Sql("INSERT INTO CreateUserRoles(RoleName,ZeActualRole)Values('Contestant','KWaViehwZeModels')");
            Sql("INSERT INTO CreateUserRoles(RoleName,ZeActualRole)Values('Viewer','Normal')");
            Sql("INSERT INTO CreateUserRoles(RoleName,ZeActualRole)Values('Audience','Normal')");
            Sql("INSERT INTO CreateUserRoles(RoleName,ZeActualRole)Values('Studio','XemStudiozzz')");
            Sql("INSERT INTO CreateUserRoles(RoleName,ZeActualRole)Values('Couturier','XemStudiozzz')");
            Sql("INSERT INTO CreateUserRoles(RoleName,ZeActualRole)Values('Tailor','XemStudiozzz')");
            Sql("INSERT INTO CreateUserRoles(RoleName,ZeActualRole)Values('make-up artist','XemStudiozzz')");

        }

        public override void Down()
        {
        }
    }
}
