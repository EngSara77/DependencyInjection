using DependencyInjection.Data.Services.Interfaces;

namespace DependencyInjection.Data.Services
{
    public class Operation: IScopedOperation, ISingletonOperation, ITransientOperation
    {
        public Operation()
        {
            this.OperationId = Guid.NewGuid();

        }
        public Guid OperationId { get; }
    }
}
