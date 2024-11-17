namespace AccountProvider.Data.Databases
{
    public class DatabaseConfig
    {
        public string ConnectionString { get; set; }
        public bool UseInMemoryDatabase { get; set; }

        // Skapare för att lägga en anslutningssträng och databas.
        public DatabaseConfig(string connectionString, bool useInMemoryDatabase = false)
        {
            ConnectionString = connectionString;
            UseInMemoryDatabase = useInMemoryDatabase;
        }
    }
}
