using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp2
{
    public class Service : IService
    {
        private readonly ILoggerFactory _logger;
        
        public Service(ILoggerFactory logger)
        {
            _logger = logger;
        }

        public int _counter { get; set; }

        public void IncrementCounter()
        {
            _counter++;
        }

        public void GetCounter()
        {
            _logger.CreateLogger<Service>().LogInformation(_counter.ToString());
        }
        
    }
}
