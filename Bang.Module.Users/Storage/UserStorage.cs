using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bang.Core.Data.Generic;
using Bang.Core.Data.Mongo;
using Bang.Module.Users.Storage.Objects;

namespace Bang.Module.Users.Storage
{
    public class UserStorage : IStorage<User>
    {
        private MongoConnection<User> UserConnection = new MongoConnection<User>();

        public void Create(User obj)
        {
            var result = this.UserConnection.MongoCollection.Save(obj);

            if (!result.Ok)
            {
                throw new Exception("Unable to save user");
            }

        }
    }
}
