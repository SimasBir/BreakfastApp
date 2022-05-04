using BreakfastApp;
using BreakfastApp.Services;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.ConfigureServices();
var serviceProvider = services.BuildServiceProvider();
var mainService = serviceProvider.GetService<MainService>();

mainService.Execute();