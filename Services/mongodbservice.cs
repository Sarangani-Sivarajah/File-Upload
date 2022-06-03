using FileUpload.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDB.Bson;


namespace FileUpload.Services
{
    public class mongodbService
    {
        private readonly IMongoCollection<Documents> Documents;

        public mongodbService(IOptions<mongodbSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.FilesUploadDB);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.FilesUploadDB);
            Documents = database.GetCollection<Documents>(mongoDBSettings.Value.Documents);
        }

    }
}
