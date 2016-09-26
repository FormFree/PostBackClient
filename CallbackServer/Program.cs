using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin.Hosting;
using Owin;

namespace CallbackServer
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var app = WebApp.Start<Program>("http://localhost:8080"))
            {
                Console.WriteLine("Waiting...");
                Console.ReadKey();
            }
        }

        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute("DefaultAPI", "{controller}/{action}");
            app.UseWebApi(config);
        }
    }
}
