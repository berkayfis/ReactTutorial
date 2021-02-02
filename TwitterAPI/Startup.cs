using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using TwitterAPI.Core.Context;
using TwitterAPI.Core.Mapper;
using TwitterAPI.Core.Posts;
using TwitterAPI.Providers;
using TwitterAPI.Services;

namespace TwitterAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // requires using Microsoft.Extensions.Options
            services.Configure<TwitterDatabaseSettings>(
                Configuration.GetSection(nameof(TwitterDatabaseSettings)));

            services.AddSingleton<ITwitterDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<TwitterDatabaseSettings>>().Value);

            services.AddScoped<IPostService,PostService>();

            services.AddScoped<IPostProvider, PostProvider>();

            services.AddAutoMapper(typeof(CustomMapperProfile));
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
