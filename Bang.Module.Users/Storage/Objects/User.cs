using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bang.Core.Data.Mongo;

namespace Bang.Module.Users.Storage.Objects
{
    public class User : MongoEntity
    {
        public string Email { get; set; }
    }
}
