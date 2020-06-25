namespace SiteDezmembrariFord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedCounties : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO COUNTIES VALUES ('Bucureşti')");
            Sql("INSERT INTO COUNTIES VALUES ('Alba')");
            Sql("INSERT INTO COUNTIES VALUES ('Arad')");
            Sql("INSERT INTO COUNTIES VALUES ('Arges')");
            Sql("INSERT INTO COUNTIES VALUES ('Bacău')");
            Sql("INSERT INTO COUNTIES VALUES ('Bihor')");
            Sql("INSERT INTO COUNTIES VALUES ('Bistriţa-Năsăud')");
            Sql("INSERT INTO COUNTIES VALUES ('Braşov')");
            Sql("INSERT INTO COUNTIES VALUES ('Brăila')");
            Sql("INSERT INTO COUNTIES VALUES ('Buzău')");
            Sql("INSERT INTO COUNTIES VALUES ('Caraş-Severin')");
            Sql("INSERT INTO COUNTIES VALUES ('Călăraşi')");
            Sql("INSERT INTO COUNTIES VALUES ('Cluj')");
            Sql("INSERT INTO COUNTIES VALUES ('Constanţa')");
            Sql("INSERT INTO COUNTIES VALUES ('Covasna')");
            Sql("INSERT INTO COUNTIES VALUES ('Dâmboviţa')");
            Sql("INSERT INTO COUNTIES VALUES ('Dolj')");
            Sql("INSERT INTO COUNTIES VALUES ('Galaţi')");
            Sql("INSERT INTO COUNTIES VALUES ('Giurgiu')");
            Sql("INSERT INTO COUNTIES VALUES ('Gorj')");
            Sql("INSERT INTO COUNTIES VALUES ('Harghita')");
            Sql("INSERT INTO COUNTIES VALUES ('Hunedoara')");
            Sql("INSERT INTO COUNTIES VALUES ('Ialomiţa')");
            Sql("INSERT INTO COUNTIES VALUES ('Iaşi')");
            Sql("INSERT INTO COUNTIES VALUES ('Ilfov')");
            Sql("INSERT INTO COUNTIES VALUES ('Maramureş')");
            Sql("INSERT INTO COUNTIES VALUES ('Mehedinţi')");
            Sql("INSERT INTO COUNTIES VALUES ('Mureş')");
            Sql("INSERT INTO COUNTIES VALUES ('Neamţ')");
            Sql("INSERT INTO COUNTIES VALUES ('Olt')");
            Sql("INSERT INTO COUNTIES VALUES ('Prahova')");
            Sql("INSERT INTO COUNTIES VALUES ('Satu Mare')");
            Sql("INSERT INTO COUNTIES VALUES ('Sălaj')");
            Sql("INSERT INTO COUNTIES VALUES ('Sibiu')");
            Sql("INSERT INTO COUNTIES VALUES ('Suceava')");
            Sql("INSERT INTO COUNTIES VALUES ('Teleorman')");
            Sql("INSERT INTO COUNTIES VALUES ('Timiş')");
            Sql("INSERT INTO COUNTIES VALUES ('Tulcea')");
            Sql("INSERT INTO COUNTIES VALUES ('Vâlcea')");
            Sql("INSERT INTO COUNTIES VALUES ('Vaslui')");
            Sql("INSERT INTO COUNTIES VALUES ('Vrancea')");

        }
        
        public override void Down()
        {
        }
    }
}
