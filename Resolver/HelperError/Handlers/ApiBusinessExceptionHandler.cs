using Resolver.HelperError.IExceptions;
using System;

namespace Resolver.HelperError.Handlers
{
    public class ApiBusinessExceptionHandler : BaseExceptionHandler
    {
        static ApiBusinessExceptionHandler _instance;
        private ApiBusinessExceptionHandler() { }
        public static ApiBusinessExceptionHandler GetInstance()
        {
            if (_instance == null)
                _instance = new ApiBusinessExceptionHandler();
            return _instance;
        }

        public override IApiExceptions HandleExceptions(Exception ex)
        {
            if (ex is ApiBusinessException)
                return (ApiBusinessException)ex;
            return Mychainhandler.HandleExceptions(ex);
        }
    }
}
