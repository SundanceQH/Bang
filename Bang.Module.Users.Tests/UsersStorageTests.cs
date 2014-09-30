using System;
using Bang.Core.Data.Generic;
using Bang.Module.Users.Service;
using Bang.Module.Users.Storage;
using Bang.Module.Users.Storage.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Bson;
using Simple.Mocking;

namespace Bang.Module.Users.Tests
{
    [TestClass]
    public class UserStorageTests
    {
        [TestMethod]
        public void UserStorage_CRUD()
        {
            IStorage<User> UserStorage = new UserStorage();

            string TestEmail = "test@test.com";
            string TestEmailUpdated = "test-updated@test.com";

            User TestUser = new User { Email = TestEmail };
            UserStorage.Create(TestUser);

            //Check to see a record was created with a valid Id
            Assert.AreNotEqual(new ObjectId(), TestUser.Id);

            //Get that record By Id
            User TestUser2 = UserStorage.Read(TestUser.Id.ToString());

            //Make sure the record in the database has the email address we created
            Assert.AreEqual(TestEmail, TestUser2.Email);

            TestUser2.Email = TestEmailUpdated;
            UserStorage.Update(TestUser2);

            //Get the record By Id again for updated email address
            User TestUser3 = UserStorage.Read(TestUser.Id.ToString());

            //Make sure the record in the database has the email address we updated with
            Assert.AreEqual(TestEmailUpdated, TestUser3.Email);

            //Delete User
            UserStorage.Delete(TestUser.Id.ToString());

            //Get the record By Id again to make sure it got deleted
            User TestUser4 = UserStorage.Read(TestUser.Id.ToString());

            //UserShould be deleted now
            Assert.IsNull(TestUser4);


        }
    }
}
