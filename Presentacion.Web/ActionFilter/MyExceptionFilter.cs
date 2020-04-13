using log4net;
using System.Web.Http.Filters;

namespace Presentacion.Web.ActionFilter
{
    public class MyExceptionFilter : ExceptionFilterAttribute
    {
        readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public override void OnException(HttpActionExecutedContext context)
        {
            string exceptionMessage = string.Empty;
            if (context.Exception.InnerException == null)
            {
                exceptionMessage = context.Exception.Message;
            }
            else
            {
                exceptionMessage = context.Exception.InnerException.Message;
            }

            //Guardar error en archivo
            logger.Error(exceptionMessage);
        }
    }
}