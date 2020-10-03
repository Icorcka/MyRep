using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace GuitarStoreM.Models
{
    public class Guitar
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [Display(Name = "Модель")]
        public string Name { get; set; }
        [Display(Name = "Производитель")]
        public string Producer { get; set; }
        [Display(Name = "Тип")]
        public string Type { get; set; }
        [Display(Name = "Цена")]
        public int Price { get; set; }

        public string ImageId { get; set; } 

        public bool HasImage()
        {
            return !String.IsNullOrWhiteSpace(ImageId);
        }
    }
}
