using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Veteran.Data.Models;

namespace VeteranFunctions
{
    public  class CrmFunction
    {
        [FunctionName("crmaggregation")]
        public async Task Run([BlobTrigger("source/{name}", Connection = "storageconnection")]Stream myBlob, string name, ILogger log)
        {
            Crm crm = new Crm();

            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");

        }
    }
}
