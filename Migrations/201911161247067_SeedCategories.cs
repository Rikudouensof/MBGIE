namespace MBGIE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedCategories : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (Name) VALUES('News')");
            Sql("INSERT INTO Categories (Name) VALUES('Models')");
            Sql("INSERT INTO Categories (Name) VALUES('Info')");
            Sql("INSERT INTO Categories (Name) VALUES('Event')");
            Sql("INSERT INTO Categories (Name) VALUES('Update')");
            Sql("INSERT INTO Categories (Name) VALUES('acknowledgement')");
        }
        
        public override void Down()
        {
        }
    }
}
