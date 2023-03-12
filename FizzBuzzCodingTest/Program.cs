using FizzBuzzCodingTest.GameConditions;
using FizzBuzzCodingTest.GameConditions.Interfaces;
using FizzBuzzCodingTest.Services;
using FizzBuzzCodingTest.Services.Interfaces;
using FizzBuzzCodingTest.UI;
using FizzBuzzCodingTest.UI.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

var services = new ServiceCollection();

var builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false);

IConfiguration configuration = builder.Build();

services.AddLogging(log =>
{
    log.AddConfiguration(configuration.GetSection("Logging"));
    log.AddConsole();
});

services.AddSingleton(new List<IGameCondition>
            {
                new FizzBuzzCondition(),
                new FizzCondition(),
                new BuzzCondition()
            });

services.AddTransient<IFizzBuzzService, FizzBuzzService>();
services.AddTransient<IConsoleUI, ConsoleUI>();

services.BuildServiceProvider()
    .GetService<IConsoleUI>()?
    .Run(args);