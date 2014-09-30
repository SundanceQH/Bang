namespace Bang.Presentation
{
    using Bang.Core.Data.Generic;
    using Bang.Module.Users.Service;
    using Bang.Module.Users.Storage;
    using Bang.Module.Users.Storage.Objects;
    using Nancy;
    using Nancy.Bootstrapper;
    using Nancy.TinyIoc;

    public class Bootstrapper : DefaultNancyBootstrapper
    {
        // The bootstrapper enables you to reconfigure the composition of the framework,
        // by overriding the various methods and properties.
        // For more information https://github.com/NancyFx/Nancy/wiki/Bootstrapper

        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            container.Register<IStorage<User>, UserStorage>();
            container.Register<IUserService, UserService>();
        }  
    }
}