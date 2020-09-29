using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenizKabacelik.JwtProje.WebApi.CustomFilters
{
    public class ValidModel : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //var gelenMesajlar= context.ModelState.Values.Select(I => I.Errors.SelectMany(I => I.ErrorMessage));

            if (!context.ModelState.IsValid)
            {


                context.Result = new BadRequestObjectResult(context.ModelState);

            }




        }
    }
}