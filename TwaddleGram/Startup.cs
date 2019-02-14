using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TwaddleGram.Data;
using TwaddleGram.Models.Interfaces;
using TwaddleGram.Models.Services;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace TwaddleGram
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder().AddEnvironmentVariables();
            builder.AddUserSecrets<Startup>();
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc();

            services.AddDbContext<TwaddleDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IPost, PostManager>();
            services.AddScoped<IUser, UserManager>();
            services.AddScoped<IComment, CommentManager>();

            //string storageConnectionString = Environment.GetEnvironmentVariable("StorageConnection");

            //CloudStorageAccount storageAccount = null;
            //CloudBlobContainer cloudBlobContainer = null;
            //string sourceFile = null;
            //string destinationFile = null;

            //// Check whether the connection string can be parsed.
            //if (CloudStorageAccount.TryParse(storageConnectionString, out storageAccount))
            //{
            //    // do some stuff
            //}
            //else
            //{
            //    // Otherwise, let the user know that they need to define the environment variable.
            //    Console.WriteLine(
            //        "A connection string has not been defined in the system environment variables. " +
            //        "Add a environment variable named 'storageconnectionstring' with your storage " +
            //        "connection string as a value.");
            //    Console.WriteLine("Press any key to exit the sample application.");
            //    Console.ReadLine();
            //}

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseStaticFiles();

        }
    }
}
