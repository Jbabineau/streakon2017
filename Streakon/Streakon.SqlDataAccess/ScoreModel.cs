namespace Streakon.SqlDataAccess
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ScoreModel : DbContext
    {
        // Your context has been configured to use a 'ScoreModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Streakon.SqlDataAccess.ScoreModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ScoreModel' 
        // connection string in the application configuration file.
        public ScoreModel()
            : base("name=ScoreModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<HighScore> MyEntities { get; set; }
    }

    public class HighScore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public int Kills { get; set; }
        public int Blocks { get; set; }
        public int Misses { get; set; }
    }
}