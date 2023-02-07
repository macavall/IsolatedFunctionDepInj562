using Microsoft.Extensions.Logging;

namespace FunctionApp2
{
    public interface IService
    {
        public int _counter { get; set; }

        public void IncrementCounter() 
        { 
            _counter++; 
        }

        public void GetCounter();

    }
}