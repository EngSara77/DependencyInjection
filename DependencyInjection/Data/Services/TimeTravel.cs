using DependencyInjection.Data.Services.Interfaces;

namespace DependencyInjection.Data.Services
{
    public class TimeTravel : ITimeTravel
    {
        public DateTime DT { get; set; } = DateTime.Now;
    }
}
