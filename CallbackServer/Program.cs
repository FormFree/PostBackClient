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
            // The below line says that the self-hosting configuration is contained
            // within this class. You may want to seperate that out.
            using (var app = WebApp.Start<Program>("http://localhost:8080"))
            {
                Console.WriteLine("Waiting...");
                // Wait for the user to force an exit.
                Console.ReadKey();
            }

            // The above code does not take into account the WebApp being
            // disposed of prematurely. You may want to write a loop to
            // restart the WebApp if that does happen.
        }

        public void Configuration(IAppBuilder app)
        {
            // Configures the routes for the controllers.
            // The configuration below would put the callback
            // at the location "/Callback/Handle".
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute("DefaultAPI", "{controller}/{action}");
            app.UseWebApi(config);
        }
    }
}
