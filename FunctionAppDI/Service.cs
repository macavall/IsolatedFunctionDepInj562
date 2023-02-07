using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionAppDI
{
    public class Service : IService
    {
        private readonly ILogger _logger;

        public Service(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Service>();
        }
        public int counter  { get; set; }
        public void IncrementCounter() { counter++; }

        public void GetCounter() { _logger.LogInformation(counter.ToString()) }


    }
}
