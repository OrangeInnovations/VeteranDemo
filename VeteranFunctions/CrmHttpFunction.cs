using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Veteran.Data.Models;

namespace VeteranFunctions
{
    public class CrmHttpFunction
    {
        [FunctionName("crmhttpaggregation")]
        public async Task<IActionResult> Run(
            HttpRequest req, string category, int? id, ILogger log)
        {
            var message = String.Format($"Category: {category}, ID: {id}");

            return new OkObjectResult(message);
        }
    }
}
