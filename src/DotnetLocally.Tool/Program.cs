using DotnetLocally.Tool.Commands;
using DotnetLocally.Core.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Spectre.Console.Cli;

var registrations = new ServiceCollection();

var registrar = new MSDITypeRegistrar(registrations);

var app = new CommandApp<DefaultCommand>();
app.Configure(config => {
#if DEBUG
    config.PropagateExceptions();
    config.ValidateExamples();
#endif
});
