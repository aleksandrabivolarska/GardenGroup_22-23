using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace DAL
{
    public class MongoHelper
    {
        protected static MongoClient _client;
        protected static MongoHelper _helper; 

        private MongoHelper() { _client = new MongoClient("mongodb+srv://gg3:gg3@cluster0.mhym582.mongodb.net/?retryWrites=true&w=majority"); }

        public static MongoHelper getInstance() 
        {
            if (_helper == null)
                _helper = new MongoHelper();
            return _helper;
        }

        public List<MongoDB.Bson.BsonDocument> getAllDbs()
        {
            List<MongoDB.Bson.BsonDocument> db = _client.ListDatabases().ToList();
            return db;
        }

    }
}
