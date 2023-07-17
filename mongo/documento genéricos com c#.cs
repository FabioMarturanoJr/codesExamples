using MongoDB.Driver;

public class Test
{
    private MongoDB.Driver.IMongoClient client;
    private MongoDB.Driver.IMongoDatabase database; 
    private MongoDB.Driver.IMongoCollection<MongoDB.Bson.BsonDocument> collection;

    public Test()
    {
        #pragma warning disable 0618
        MongoDB.Bson.BsonDefaults.GuidRepresentationMode = MongoDB.Bson.GuidRepresentationMode.V3;
        MongoDB.Bson.Serialization.BsonSerializer.RegisterSerializer(new MongoDB.Bson.Serialization.Serializers.GuidSerializer(MongoDB.Bson.GuidRepresentation.Standard));
        
        string uri = "mongodb://testuser:mysecret@localhost:50011,localhost:50012,localhost:50013/csharptest?replicaSet=replSet&authSource=admin&retryWrites=true&readConcernLevel=majority";
    
        this.client = new MongoDB.Driver.MongoClient(uri);
        this.database = client.GetDatabase("csharptesting");
        this.collection = database.GetCollection<MongoDB.Bson.BsonDocument>("somecollection");

        // CLEAR OUT ALL THE PRIOR TEST RECORDS
        this.collection.DeleteMany(new MongoDB.Bson.BsonDocument());
    }

    public void insertRecords() 
    {
        System.Console.WriteLine("Begin insert record 1...");
        MongoDB.Bson.BsonDocument document1 = new MongoDB.Bson.BsonDocument {
             {"ItemId", new MongoDB.Bson.BsonBinaryData(new System.Guid("13202a78-668d-4b17-9aac-78524d50925e"), MongoDB.Bson.GuidRepresentation.Standard)},
             {"FieldValue", 
                new MongoDB.Bson.BsonDocument {
                    {"FieldName", "IsCity"},
                    {"Value", true}
                }
             }
        };
        this.collection.InsertOne(document1);
        System.Console.WriteLine("End insert record 1");

        System.Console.WriteLine("Begin insert record 2...");
        MongoDB.Bson.BsonDocument document2 = new MongoDB.Bson.BsonDocument {
             {"ItemId", new MongoDB.Bson.BsonBinaryData(new System.Guid("26566f9a-712d-44fe-9baa-722aa53e0038"), MongoDB.Bson.GuidRepresentation.Standard)},
             {"FieldValue", 
                new MongoDB.Bson.BsonDocument {
                    {"FieldName", "Address"},
                    {"Value", "Address"}
                }
             }
        };
        this.collection.InsertOne(document2);
        System.Console.WriteLine("End insert record 2");


        System.Console.WriteLine("Begin insert record 3...");
        MongoDB.Bson.BsonDocument document3 = new MongoDB.Bson.BsonDocument {
             {"ItemId", new MongoDB.Bson.BsonBinaryData(new System.Guid("6640a83a-a47d-4016-9d50-70c41425e099"), MongoDB.Bson.GuidRepresentation.Standard)},
             {"FieldValue", 
                new MongoDB.Bson.BsonDocument {
                    {"FieldName", "Address"},
                    {"Value", 
                        new MongoDB.Bson.BsonDocument {
                            { "Data1", "String" },
                            { "Data2", new MongoDB.Bson.BsonBinaryData(new System.Guid("a9bde160-22af-4cf7-a201-57db8b392c4d"), MongoDB.Bson.GuidRepresentation.Standard)}
                        }
                    }
                }
             }
        };
        this.collection.InsertOne(document3);
        System.Console.WriteLine("End insert record 3");
    }

    public void find()
    {
        System.Console.WriteLine("Find data...");

        foreach(MongoDB.Bson.BsonDocument record in this.collection.Find(new MongoDB.Bson.BsonDocument()).ToList())
        {
            System.Console.WriteLine(record);
        }

        System.Console.WriteLine("End find data");
    }
}