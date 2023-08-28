using DependencyInjection.Data.Services.Interfaces;

namespace DependencyInjection.Data.Services
{
    public class OperationService
    {
        public IScopedOperation ScopedOperation;
        public ITransientOperation TransientOperation;
        public ISingletonOperation SingletonOperation;


        public OperationService(IScopedOperation scopedOperation,
            ITransientOperation transientOperation,
            ISingletonOperation singletonOperation)
        {
            
            ScopedOperation = scopedOperation;
            TransientOperation = transientOperation;
            SingletonOperation = singletonOperation;
        }
    }
}
