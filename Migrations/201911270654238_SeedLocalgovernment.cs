namespace MBGIE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedLocalgovernment : DbMigration
    {
        public override void Up()
        {


            Sql("INSERT INTO Localgovernments(Name) VALUES('Aninri')");
            Sql("INSERT INTO Localgovernments(Name) VALUES('Awgu')");
            Sql("INSERT INTO Localgovernments(Name) VALUES('Enugu East')");
            Sql("INSERT INTO Localgovernments(Name) VALUES('Enugu South')");
            Sql("INSERT INTO Localgovernments(Name) VALUES('Enugu North')");
            Sql("INSERT INTO Localgovernments(Name) VALUES('Ezeagu')");
            Sql("INSERT INTO Localgovernments(Name) VALUES('Igbo Eze North')");
            Sql("INSERT INTO Localgovernments(Name) VALUES('Igbo Eze South')");
            Sql("INSERT INTO Localgovernments(Name) VALUES('Isi Uzo')");
            Sql("INSERT INTO Localgovernments(Name) VALUES('Igbo Etiti')");
            Sql("INSERT INTO Localgovernments(Name) VALUES('Nkanu East')");
            Sql("INSERT INTO Localgovernments(Name) VALUES('Nkanu West')");
            Sql("INSERT INTO Localgovernments(Name) VALUES('Nsukka')");
            Sql("INSERT INTO Localgovernments(Name) VALUES('Oji River')");
            Sql("INSERT INTO Localgovernments(Name) VALUES('Udenu')");
            Sql("INSERT INTO Localgovernments(Name) VALUES('Udi')");
            Sql("INSERT INTO Localgovernments(Name) VALUES('Uzo Uwani')");
        }
        
        public override void Down()
        {
        }
    }
}
