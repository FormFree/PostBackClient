using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Web.Http;

namespace CallbackServer.Controllers
{
    /// <summary>
    /// Simple WebAPI controller.
    /// </summary>
    public class CallbackController : ApiController
    {
        /// <summary>
        /// This method handles the Webhook postback from the
        /// FormFree API. It's exact url location is dependent
        /// upon your routing configuration and domain.
        /// </summary>
        /// <param name="data">The body data posted by FormFree.</param>
        [HttpPost]
        public void Handle([FromBody] TmpModel data)
        {
            // TODO: Do something useful.
            // At the moment we just print the fact the callback happened with
            // the data also printed.
            Console.WriteLine("Called...");
            Console.WriteLine($"Data: {data.VOD_ID}, {data.OrderStatus}, {data.ReportID}");
        }

    }

    /// <summary>
    /// A simple model class to represent the body of the POST.
    /// 
    /// It is important to note that in order for the mapping
    /// to work the names of the properties must match spelling
    /// and case exactly of those in the POST body. 
    /// </summary>
    public class TmpModel
    {
        [Required]
        public Guid VOD_ID { get; set; }

        [Required]
        public int OrderStatus { get; set; }

        public Guid? ReportID { get; set; }
    }
}