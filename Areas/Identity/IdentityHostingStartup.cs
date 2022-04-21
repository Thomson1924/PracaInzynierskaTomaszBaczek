using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PracaInżynierskaTomaszBaczek.Data;

[assembly: HostingStartup(typeof(PracaInżynierskaTomaszBaczek.Areas.Identity.IdentityHostingStartup))]
namespace PracaInżynierskaTomaszBaczek.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}