using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ModelValidation.Model
{
    public class ProductFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new System.NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
           if(!context.ModelState.IsValid)
           {
               context.Result = new BadRequestObjectResult(context.ModelState);
           }
        }
    }
}