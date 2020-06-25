namespace SiteDezmembrariFord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSubCategories : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Anvelope', 2)");

            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Set placute frana, frana disc', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Disc frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Set garnituri de frictiune frana tambur', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Set accesorii, placute frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Indicator de uzura placute frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Set frane', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Protectie stropire, disc frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Etrier frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Set reparatie, etrier', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Piston, etrier frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Set bucsi de ghidaj, etrier frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Suport, etrier', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Surub, disc frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Set saboti frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Tambur frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Set accesorii, sabot de frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Set frana, frana tambur', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Reglaj, frana tambur', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Furtun frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Lichid de frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Conducta frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Furtun vacuum, sistem de franare', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Comutator presiune, hidraulica frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Acumulator presiune, frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Cablu, frana de parcare', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Set saboti frana, frana de mana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Set reparatie, arbore frana parcare', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Comutator, bec control frana de mana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Control al dinamicii de rulare', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Inel senzor, abs', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Unitate hidraulica, sistem franare', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Senzor, acceleratie longitudinala / transversala', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Unitate de control, frana / conducere', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Releu supratensiune, abs', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Pompa centrala frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Set reparatie, pompa centrala frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Rezervor lichid frana / piese', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Cilindru receptor frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Set reparatie, cilindru receptor frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Servofrana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Pompa vacuum, sistem de franare', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Regulator forta de frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Comutator lumini frana', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Disc frana de performanta', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Placute frana de performanta', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Frana de parcare', 3)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Scule pentru sistem de frânare', 3)");

            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Ulei de motor', 12)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Ulei de transmisie', 12)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Ulei cutie automata', 12)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Solutie curatire geam', 12)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Antigel', 12)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Ulei hidraulic', 12)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Ulei servodirectie', 12)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Lichid de frana', 12)");
            Sql("INSERT INTO SubCategories (Name, CategoryId) VALUES ('Curatare filtru de particule', 12)");



        }
        
        public override void Down()
        {
        }
    }
}
