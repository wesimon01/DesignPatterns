// See https://aka.ms/new-console-template for more information
using DesignPatterns.Core.Structural.Adapter;
using DesignPatterns.UI.Services;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddScoped<AdapterService>()
    .BuildServiceProvider();

var adapterService = serviceProvider.GetRequiredService<AdapterService>();
var facadeService = serviceProvider.GetRequiredService<FacadeService>();
var compositeService = serviceProvider.GetRequiredService<CompositeService>();


adapterService.Run();
await facadeService.RunAsync();
compositeService.Run();