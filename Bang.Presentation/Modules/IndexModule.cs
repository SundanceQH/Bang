namespace Bang.Presentation
{
    using Bang.Module.Users.Service;
    using Bang.Module.Users.Storage.Objects;
    using Nancy;

    public class IndexModule : NancyModule
    {
        private IUserService UserService;

        public IndexModule(IUserService UserService)
        {
            this.UserService = UserService;

            Get["/"] = parameters =>
            {
                User NewUser = new User { Email = "a@b.com "};
                this.UserService.Create(NewUser);
                return View["index", NewUser.Id.ToString()];
            };
        }
    }
}