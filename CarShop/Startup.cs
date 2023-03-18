using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using CarShop.Data.Interfaces;
using CarShop.Data.Mocks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;
using CarShop.Data;
using CarShop.Data.Repository;
using CarShop.Migrations;
using CarShop.Models;

namespace CarShop;

public class Startup
{
    private IConfigurationRoot _confString;

    public Startup(IHostingEnvironment hostEnv)
    {
        _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<DBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
        services.AddTransient<IAdvertisement, CarRepository>();

        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddScoped(sp => Models.ShopCart.GetCart(sp));

        services.AddMvc(options => options.EnableEndpointRouting = false);
        services.AddMemoryCache();
        services.AddSession();
    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
        app.UseDeveloperExceptionPage();
        app.UseStatusCodePages();
        app.UseStaticFiles();
        app.UseSession();
        app.UseMvcWithDefaultRoute();

        using (var scope = app.ApplicationServices.CreateScope())
        {
            DBContent content = scope.ServiceProvider.GetRequiredService<DBContent>();
            DBObjects.Initial(content);
        }
    }
}