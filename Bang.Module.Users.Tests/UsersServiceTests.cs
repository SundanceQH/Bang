using System;
using Bang.Core.Data.Generic;
using Bang.Module.Users.Service;
using Bang.Module.Users.Storage.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Bson;
using Simple.Mocking;

namespace Bang.Module.Users.Tests
{
    [TestClass]
    public class UsersServiceTests
    {
        [TestMethod]
        public void UserService_Create()
        {
            //Mock Storage
            IStorage<User> UserStorage = Mock.Interface<IStorage<User>>();

            //Create a fake UserId to ensure that the storage is actually called
            ObjectId TestId = new ObjectId("507f1f77bcf86cd799439011");

            //Mock the UserStorage.Create method
            //If the method is called, take the first paramter and assign our fake Id to the Id
            Expect.MethodCall(() => UserStorage.Create(Any<User>.Value)).Executes(parameters => ((User)parameters[0]).Id = TestId);

            //Instanciate our service with our fake Storage
            IUserService UserService = new UserService(UserStorage);

            //Create a fake user without an id
            User TestUser = new User { Email = "test@test.com" };
            UserService.Create(TestUser);

            //Confirm that the Id was set on our user obejct to the fake id we defined
            Assert.AreEqual(TestUser.Id, TestId);

        }
    }
}
