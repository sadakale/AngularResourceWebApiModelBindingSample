using Nancy;
using Nancy.Conventions;

namespace WebApiSample
{
    public class CustomBoostrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions conventions)
        {
            base.ConfigureConventions(conventions);

            conventions.StaticContentsConventions.Add(
                StaticContentConventionBuilder.AddDirectory("scripts", @"scripts")
                );

            conventions.StaticContentsConventions.Add(
                StaticContentConventionBuilder.AddDirectory("", @"static")
                );
        }
    }
}