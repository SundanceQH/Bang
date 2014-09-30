using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Bang.Core.Data.Mongo
{
    public interface IMongoEntity
    {
        ObjectId Id { get; set; }
    }
}
