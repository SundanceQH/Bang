using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bang.Core.Data.Generic;
using Bang.Core.Data.Mongo;
using Bang.Module.Users.Storage.Objects;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace Bang.Module.Users.Service
{
    public class UserService : IUserService
    {
        private IStorage<User> UserStorage;

        public UserService(IStorage<User> UserStorage)
        {
            this.UserStorage = UserStorage;
        }

        public void Create(User user)
        {
            UserStorage.Create(user);
        }
    }
}
