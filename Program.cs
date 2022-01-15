var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddDataAnnotationsLocalization();

var app = builder.Build();

app.UseRouting();

app.MapControllers();

app.Run();
