using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http.Headers;
using System.Text;
using System.Net.Http;
using System.Net;

namespace StreamServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StreamController : ControllerBase
    {
        private readonly ILogger<StreamController> _logger;

        public StreamController(ILogger<StreamController> logger)
        {
            _logger = logger;
        }    

        [HttpGet]
        public ActionResult Get()
        {
            string path = Path.Join(Directory.GetCurrentDirectory(), "Static", "Fuck-You-Annette-Sidor", "540p.mp4");
            return PhysicalFile(path, "application/octet-stream", enableRangeProcessing: true);  
        }
    }
}
