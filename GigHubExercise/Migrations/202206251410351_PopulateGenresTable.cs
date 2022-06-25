namespace GigHubExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id,Name) VALUES (1, 'Rock')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (2, 'Blues')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (3, 'Reggae')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (4, 'Pop')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id BETWEEN 1 AND 4");
        }
    }
}
