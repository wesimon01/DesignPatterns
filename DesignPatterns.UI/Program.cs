// See https://aka.ms/new-console-template for more information
using DesignPatterns.UI.Services;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddScoped<AdapterService>()
    .AddScoped<FacadeService>()
    .AddScoped<CompositeService>()
    .AddScoped<StrategyService>()
    .BuildServiceProvider();

var adapterService = serviceProvider.GetRequiredService<AdapterService>();
var facadeService = serviceProvider.GetRequiredService<FacadeService>();
var compositeService = serviceProvider.GetRequiredService<CompositeService>();
var strategyService = serviceProvider.GetRequiredService<StrategyService>();

//adapterService.Run();
//await facadeService.RunAsync();
//compositeService.Run();

strategyService.Run();