using System.Linq;
using dio_coruse_api.Controllers.Models.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace dio_coruse_api.Filters
{
    public class CustomModelStateValidation : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var validateVewModel = new ValidateFieldViewModelOutput(context.ModelState.SelectMany(
                    sm => sm.Value.Errors).Select(
                    s => s.ErrorMessage));
                context.Result = new BadRequestObjectResult(validateVewModel);
            }
            
        }
    }
}