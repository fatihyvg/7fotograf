using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using _7fotograf.Database;
using _7fotograf.Models;
using _7fotograf.Interfaces;
namespace _7fotograf
{
    public class Startup
    {
        public Startup(IHostEnvironment env)
        {
            ConfigurationBuilder  builder = new ConfigurationBuilder();
            builder.SetBasePath(env.ContentRootPath);
            builder.AddJsonFile("appsettings.json",optional:true,reloadOnChange:true);
            this.Configuration = builder.Build(); 
            
        }
        public IConfiguration Configuration
        {
            get; 
        }
        public void ConfigureServices(IServiceCollection services)
        {
             
             services.AddControllersWithViews();
             services.AddRazorPages();
             services.AddControllersWithViews().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Latest);
             services.AddDbContext<Connection>(options => options.UseSqlServer(Configuration.GetConnectionString("Connection")));
             services.AddControllersWithViews().AddJsonOptions(opt => 
             {  
                 opt.JsonSerializerOptions.PropertyNamingPolicy = null;
                 opt.JsonSerializerOptions.DictionaryKeyPolicy = null;
             });
             services.AddScoped<IImagePosition,ImagePosition>();
             services.AddScoped<IFacebookLogin,FacebookLogin>();
             services.AddScoped<ICategory,Category>();
             services.AddScoped<IDeleteImage,DeleteImage>();
             services.AddSession(session => 
             {
                 session.Cookie.IsEssential = true;
                 session.Cookie.HttpOnly = true;
             });
             services.AddAuthentication(auth =>
             {
                 auth.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                 auth.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                 auth.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
             })
             .AddFacebook(fb =>
             {
                 fb.AppId = Configuration["AppId"];
                 fb.AppSecret = Configuration["AppSecret"];
                 fb.Events.OnRemoteFailure = context =>
                 {
                   context.Response.Redirect("/Home/Index");
                   context.HandleResponse();
                   return ThTask;
                 };
                 fb.Events.OnAccessDenied = context =>
                 {
                    context.Response.Redirect("/Home/Error");
                    context.AccessDeniedPath = "Error";
                    context.HandleResponse();
                    return ThTask;
                 };
             })
             .AddCookie(cookie =>
             {
               cookie.LoginPath = "/Home/Index";
               cookie.AccessDeniedPath ="/Home/Error";
             });
             
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseStaticFiles(StaticFiles);
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseRouting();
            app.UseEndpoints(route =>
            {
                 route.MapControllerRoute
                 (
                     name:"default",
                     pattern:"{controller=Home}/{action=Index}"
                 );
                 route.MapControllerRoute
                 (
                    name:"list",
                    pattern:"{controller=List}/{action=login}"
                 );
               route.MapRazorPages();
            });
        }
        private StaticFileOptions StaticFiles 
        {
            get
            {
                return new StaticFileOptions {
                   FileProvider = new PhysicalFileProvider
                   (
                       Path.Combine(Directory.GetCurrentDirectory(),"Contents")),RequestPath ="/Contents"
                };
            }
        }
        private Task ThTask
        {
            get
            {
                while(true)
                {
                    return Task.CompletedTask;
                }
            }
        }
    }
}
