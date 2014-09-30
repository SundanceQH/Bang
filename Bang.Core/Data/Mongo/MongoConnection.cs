using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Bang.Core.Data.Mongo
{
    public class MongoConnection<T> where T : IMongoEntity
    {
        private string ConnectionString;
        private string DatabaseName;

        public MongoCollection<T> MongoCollection { get; private set; }

        public MongoConnection(string ConnectionString, string DatabaseName)
        {
            this.ConnectionString = ConnectionString;
            this.DatabaseName = DatabaseName;

            Init();
        }

        public MongoConnection()
        {
            this.ConnectionString = System.Configuration.ConfigurationManager.AppSettings["MongoConnectionString"];
            this.DatabaseName = System.Configuration.ConfigurationManager.AppSettings["MongoDatabaseName"];

            Init();
        }

        private void Init()
        {

            var mongoClient = new MongoClient(ConnectionString);
            var mongoServer = mongoClient.GetServer();
            var db = mongoServer.GetDatabase(DatabaseName);
            MongoCollection = db.GetCollection<T>(typeof(T).Name);
        }
    }
}
