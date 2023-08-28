using DependencyInjection.Data.Services.Interfaces;

namespace DependencyInjection.Data.Services
{
    public class DependencyService
    {
        private readonly OperationService operationService;
        private readonly ISingletonOperation singletonOperation;
        private readonly IScopedOperation scopedOperation;
        private readonly ITransientOperation transientOperation;

        public DependencyService(OperationService operationService,
            ISingletonOperation singletonOperation, IScopedOperation scopedOperation,
            ITransientOperation transientOperation)
        {
            this.operationService = operationService;
            this.singletonOperation = singletonOperation;
            this.scopedOperation = scopedOperation;
            this.transientOperation = transientOperation;
        }



        public string Transient { get; set; }

        public string Scoped { get; set; }
        public string Singleton { get; set; }

        public string Transient2 { get; set; }
        public string Scoped2 { get; set; }
        public string Singleton2 { get; set; }

        


    public void TestDependencyLifeCycle()
    {
        OperationsProcess();

    }


    private void OperationsProcess()
    {
        //requested by this service
        this.Transient = transientOperation.OperationId.ToString();
        this.Scoped = scopedOperation.OperationId.ToString();
        this.Singleton = singletonOperation.OperationId.ToString();

        // requested by operation service
        this.Transient2 = operationService.TransientOperation.OperationId.ToString();
        this.Scoped2 = operationService.ScopedOperation.OperationId.ToString();
        this.Singleton2 = operationService.SingletonOperation.OperationId.ToString();
    }
}
}
