using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace FunctionApp2
{
    public class Function1
    {
        private readonly ILogger _logger;
        private readonly IService _service;
        private readonly IService _service2;

        public Function1(ILoggerFactory loggerFactory, IService service, IService service2)
        {
            _logger = loggerFactory.CreateLogger<Function1>();
            _service = service;
            _service2 = service2;
        }

        [Function("Function1")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
        {
            for (int i = 0; i < 10; i++)
            {
                _service.IncrementCounter();
                _service.GetCounter();
            }

            for (int i = 0; i < 10; i++)
            {
                _service2.IncrementCounter();
                _service2.GetCounter();
            }

            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Welcome to Azure Functions!");

            return response;
        }
    }
}
