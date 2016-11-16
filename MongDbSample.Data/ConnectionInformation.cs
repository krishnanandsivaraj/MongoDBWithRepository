using MongoDB.Driver;

namespace MongDbSample.Data
{
    public static class ConnectionInformation
    {
        public  static MongoDatabase GetConnectionInformation()
        {
        MongoClient client = new MongoClient(Commons.Default.ConnectionString);
        MongoServer server = client.GetServer();
        MongoDatabase database = server.GetDatabase(Commons.Default.DataBase);
            return database;
        }
    }
}
