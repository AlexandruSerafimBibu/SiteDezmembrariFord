namespace SiteDezmembrariFord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategories : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (Name) VALUES ('Anvelopa')");
            Sql("INSERT INTO Categories (Name) VALUES ('Sistem de franare')");
            Sql("INSERT INTO Categories (Name) VALUES ('Filtre')");
            Sql("INSERT INTO Categories (Name) VALUES ('Amortizare')");
            Sql("INSERT INTO Categories (Name) VALUES ('Motor')");
            Sql("INSERT INTO Categories (Name) VALUES ('Sistem curatare parbriz')");
            Sql("INSERT INTO Categories (Name) VALUES ('Ambreiaj/piese')");
            Sql("INSERT INTO Categories (Name) VALUES ('Suspensie,tije')");
            Sql("INSERT INTO Categories (Name) VALUES ('Electrice')");
            Sql("INSERT INTO Categories (Name) VALUES ('Sistem aprindere si bujii')");
            Sql("INSERT INTO Categories (Name) VALUES ('Uleiuri si lichide')");
            Sql("INSERT INTO Categories (Name) VALUES ('Caroserie')");
            Sql("INSERT INTO Categories (Name) VALUES ('Habitaclu si disp de confort')");
            Sql("INSERT INTO Categories (Name) VALUES ('Sustemul de esapament')");
            Sql("INSERT INTO Categories (Name) VALUES ('Curele, lanturi, role')");
            Sql("INSERT INTO Categories (Name) VALUES ('Sistem racire motor')");
            Sql("INSERT INTO Categories (Name) VALUES ('Directie')");
            Sql("INSERT INTO Categories (Name) VALUES ('Sistem alimentare')");
            Sql("INSERT INTO Categories (Name) VALUES ('Sensori, releuri')");
            Sql("INSERT INTO Categories (Name) VALUES ('Atriculatie planetara')");
            Sql("INSERT INTO Categories (Name) VALUES ('Racorduri si furtunuri')");
            Sql("INSERT INTO Categories (Name) VALUES ('Cutie de viteze')");
            Sql("INSERT INTO Categories (Name) VALUES ('Incalzire')");
            Sql("INSERT INTO Categories (Name) VALUES ('Sistem de aer conditionat')");
            Sql("INSERT INTO Categories (Name) VALUES ('Rulmenti')");
            Sql("INSERT INTO Categories (Name) VALUES ('Set reparatie')");
            Sql("INSERT INTO Categories (Name) VALUES ('Garnituri si inele')");
            Sql("INSERT INTO Categories (Name) VALUES ('Arbori cardanici')");
            Sql("INSERT INTO Categories (Name) VALUES ('Sistem de tractare')");
            Sql("INSERT INTO Categories (Name) VALUES ('Accesorii auto')");
            Sql("INSERT INTO Categories (Name) VALUES ('Scule si echipamente')");
            Sql("INSERT INTO Categories (Name) VALUES ('Chimicale auto')");
            Sql("INSERT INTO Categories (Name) VALUES ('Iluminat')");
        }
        
        public override void Down()
        {
        }
    }
}
