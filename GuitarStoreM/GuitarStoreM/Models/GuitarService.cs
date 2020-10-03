using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace GuitarStoreM.Models
{
    public class GuitarService
    {
        IGridFSBucket gridFS;   
        IMongoCollection<Guitar> Guitars; 
        public GuitarService()
        {
            string connectionString = "mongodb://localhost:27017/guitarstore";
            var connection = new MongoUrlBuilder(connectionString);
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase(connection.DatabaseName);
            gridFS = new GridFSBucket(database);
            Guitars = database.GetCollection<Guitar>("Guitars");
        }
        public async Task<IEnumerable<Guitar>> GetGuitars(int? minPrice, int? maxPrice, string name)
        {
            var builder = new FilterDefinitionBuilder<Guitar>();
            var filter = builder.Empty;
            if (!String.IsNullOrWhiteSpace(name))
            {
                filter = filter & builder.Regex("Name", new BsonRegularExpression(name));
            }
            if (minPrice.HasValue)  
            {
                filter = filter & builder.Gte("Price", minPrice.Value);
            }
            if (maxPrice.HasValue)  
            {
                filter = filter & builder.Lte("Price", maxPrice.Value);
            }

            return await Guitars.Find(filter).ToListAsync();
        }
        public async Task<Guitar> GetGuitar(string id)
        {
            return await Guitars.Find(new BsonDocument("_id", new ObjectId(id))).FirstOrDefaultAsync();
        }
        // добавление документа
        public async Task Create(Guitar p)
        {
            await Guitars.InsertOneAsync(p);
        }
        // обновление документа
        public async Task Update(Guitar p)
        {
            await Guitars.ReplaceOneAsync(new BsonDocument("_id", new ObjectId(p.Id)), p);
        }
        // удаление документа
        public async Task Remove(string id)
        {
            await Guitars.DeleteOneAsync(new BsonDocument("_id", new ObjectId(id)));
        }
        // получение изображения
        public async Task<byte[]> GetImage(string id)
        {
            return await gridFS.DownloadAsBytesAsync(new ObjectId(id));
        }
        // сохранение изображения
        public async Task StoreImage(string id, Stream imageStream, string imageName)
        {
            Guitar g = await GetGuitar(id);
            if (g.HasImage())
            {
                await gridFS.DeleteAsync(new ObjectId(g.ImageId));
            }
            ObjectId imageId = await gridFS.UploadFromStreamAsync(imageName, imageStream);
            g.ImageId = imageId.ToString();
            var filter = Builders<Guitar>.Filter.Eq("_id", new ObjectId(g.Id));
            var update = Builders<Guitar>.Update.Set("ImageId", g.ImageId);
            await Guitars.UpdateOneAsync(filter, update);
        }
    }
}
