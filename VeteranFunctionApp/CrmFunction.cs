using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace VeteranFunctionApp
{
    public static class CrmFunction
    {
        [FunctionName("crmaggregation")]
        public static void Run([BlobTrigger("datasource/{name}", Connection = "storageconnection")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
