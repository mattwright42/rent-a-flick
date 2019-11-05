namespace RentAFlick.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('The Fellowship of the Ring', 6, 2019-11-05, 2001-12-19, 5)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('The Two Towers', 6, 2019-11-05, 2002-12-18, 2)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('The Return of the King', 6, 2019-11-05, 2003-12-17, 3)");
        }
        
        public override void Down()
        {
        }
    }
}
