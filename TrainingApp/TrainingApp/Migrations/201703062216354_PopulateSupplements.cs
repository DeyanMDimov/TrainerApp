namespace TrainingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSupplements : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Supplements (Name, Dose, dateAdded) VALUES ('Semax', 20, '3/6/2017')");
            Sql("INSERT INTO Supplements (Name, Dose, dateAdded) VALUES ( 'Noopept', 20, '3/6/2017')");
            Sql("INSERT INTO Supplements (Name, Dose, dateAdded) VALUES ( 'L-Dopa', 20, '3/6/2017')");
            Sql("INSERT INTO Supplements (Name, Dose, dateAdded) VALUES ( 'Bromantane', 20, '3/6/2017')");
            Sql("INSERT INTO Supplements (Name, Dose, dateAdded) VALUES ( 'Garlic', 20, '3/6/2017')");
           

        }

        public override void Down()
        {
            Sql("DELETE FROM Supplements WHERE Id in (1,2,3,4,5)");
        }
    }
}
