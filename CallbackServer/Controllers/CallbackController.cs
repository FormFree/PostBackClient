using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Web.Http;

namespace CallbackServer.Controllers
{
    public class CallbackController : ApiController
    {

        [HttpPost]
        public void Handle([FromBody] TmpModel data)
        {
            Console.WriteLine("Called...");
            Console.WriteLine($"Data: {data.VOD_ID}, {data.OrderStatus}, {data.ReportID}");
        }

    }

    public class TmpModel
    {
        [Required]
        public Guid VOD_ID { get; set; }

        [Required]
        public int OrderStatus { get; set; }

        public Guid? ReportID { get; set; }
    }
}