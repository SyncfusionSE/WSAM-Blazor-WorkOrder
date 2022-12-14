using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Blazor;
using Blazored.LocalStorage;
//using WorkOrderApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace WorkOrderApp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            
           
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            //builder.Services.AddScoped<WorkOrderData>();
            //builder.Services.AddSingleton<WorkOrder>();
            //builder.Services.AddDbContext<OrderDataContext>(option =>
            //    option.UseSqlServer(builder.Configuration.GetConnectionString("WorkOrder")));
            builder.Services.AddSyncfusionBlazor();
            builder.Services.AddBlazoredLocalStorage();
            await builder.Build().RunAsync();
        }
    }
}
