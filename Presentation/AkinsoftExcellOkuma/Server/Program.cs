using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.OpenApi.Models;
using AkinsoftExcellOkuma.Persistence.Services;
using AkinsoftExcellOkuma.Persistence.Extensions;
using AkinsoftExcellOkuma.Server.Middlewares;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AkinsoftExcellOkuma.Persistence.Contexts;

namespace AkinsoftExcellOkuma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigurationManager configuration = builder.Configuration;

            // Add services to the container.

            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();
            builder.Services.ConfigureMapping();
            builder.Services.AddSwaggerGen(c =>
            {
                var jwtSecurityScheme = new OpenApiSecurityScheme
                {
                    BearerFormat = "JWT",
                    Name = "JWT Authentication",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = JwtBearerDefaults.AuthenticationScheme,
                    Description = "Put **_ONLY_** your JWT Bearer token on textbox below!",

                    Reference = new OpenApiReference
                    {
                        Id = JwtBearerDefaults.AuthenticationScheme,
                        Type = ReferenceType.SecurityScheme
                    }
                };
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Eagle RentACar", Version = "v1" });
                c.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        { jwtSecurityScheme, Array.Empty<string>() }
    });
            });
            builder.Services.AddApplicationServices();
            builder.Services.AddDbContext<Wolvox80012024IkaynakContext>(config =>
            {

                //var dataSourceBuilder = new NpgsqlDataSourceBuilder(configuration.GetConnectionString("PostgreSql"));
                //config.UseLoggerFactory(loggerFactory).UseNpgsql(dataSourceBuilder.Build());
                //config.ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.ManyServiceProvidersCreatedWarning)); 
                config.UseSqlServer(configuration.GetConnectionString("Mssql"));
                config.EnableSensitiveDataLogging();
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Excell Api");

            });
            app.UseHttpsRedirection();
            app.UseMiddleware<ExceptionHandlingMiddleware>();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapRazorPages();
            app.MapControllers();
            app.MapFallbackToFile("index.html");

            app.Run();
        }
    }
}
