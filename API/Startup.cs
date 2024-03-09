using IHoting = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace API
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        //IOC
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(Configuration);

            services.AddControllers();

            services.AddSwaggerGen(); 

            services.AddMvc();

            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            
        }


        // middelware
        public void Configure(IApplicationBuilder app, IHoting env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }


            // routes
            app.UseRouting();
            app.UseEndpoints(endp =>
            {
                endp.MapControllers(); 
            });

            // Swagger
            app.UseSwagger();
            app.UseSwaggerUI();
        }
    }
}
