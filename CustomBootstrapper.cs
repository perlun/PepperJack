using Nancy;
using Nancy.Configuration;

namespace PepperJack
{
    internal class CustomBootstrapper : DefaultNancyBootstrapper
    {
        public override void Configure(INancyEnvironment environment)
        {
            environment.Tracing(
                enabled: true,
                displayErrorTraces: true
            );
        }
    }
}
