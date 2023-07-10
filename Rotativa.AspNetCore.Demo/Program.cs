using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rotativa.AspNetCore;
using Rotativa.AspNetCore.Demo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMvc();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

MyRouting.RegisterRoutes(app);
RotativaConfiguration.Setup(app.Environment);
app.Run();