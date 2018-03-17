using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avisa.Net.Data;
using Avisa.Net.Data.Interface.Commons;
using Avisa.Net.Models;
using AvisaNet.Data.Repository;
using AvisaNet.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace AvisaNet
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
            AvisaNetDbContext.ConnectionString = Configuration.GetConnectionString("DefaultConnection");

            services.AddScoped(typeof(IRepository<Pessoa>),typeof(PessoaRepository));
            services.AddScoped(typeof(IRepository<Mensagem>),typeof(MensagemRepository));   
            services.AddScoped(typeof(IRepository<Ocorrencia>),typeof(OcorrenciaRepository));
            services.AddScoped(typeof(IRepository<Veiculo>),typeof(VeiculoRepository));
            services.AddScoped(typeof(IRepository<ModeloVeiculo>),typeof(ModeloVeiculoRepository));

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
