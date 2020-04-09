using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ProiectMDS.Contexts_Fitness;
using ProiectMDS.Repositories_Fitness.AbonamentRepository;
using ProiectMDS.Repositories_Fitness.AngajatRepository;
using ProiectMDS.Repositories_Fitness.ClientRepository;
using ProiectMDS.Repositories_Fitness.SuplimentRepository;
using ProiectMDS.Repositories_Fitness.ClientAbonamentRepository;
using ProiectMDS.Repositories_Fitness.ClientSuplimentRepository;

namespace ProiectMDS
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
            services.AddCors();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<Context>(option => option.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IAbonamentRepository, AbonamentRepository>();
            services.AddTransient<IAngajatRepository, AngajatRepository>();
            services.AddTransient<IClientAbonamentRepository, ClientAbonamentRepository>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IClientSuplimentRepository, ClientSuplimentRepository>();
            services.AddTransient<ISuplimentRepository, SuplimentRepository>();
            
        }
        public void Configure(IApplicationBuilder app,IHostingEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials());
            app.UseMvc();
        }

    }
}
