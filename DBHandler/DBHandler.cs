﻿using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace HabitApp.DBHandler
{
    public class DBHandler
    {
        protected IMongoCollection<BsonDocument> collection = null;

        public DBHandler(string collectionName)
        {
            this.collection = getMongoCollectionByName(collectionName);
        }

        public IMongoCollection<BsonDocument> getMongoCollectionByName(String collectionName)
        {
            DatabaseUtil dbUtil = new DatabaseUtil();
            return dbUtil.getCollection(collectionName);
        }

    }
}
